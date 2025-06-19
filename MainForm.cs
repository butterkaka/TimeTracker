using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;
using TimeTracker.Data;
using TimeTracker.Models;
using TimeTracker.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TimeTracker
{
    internal partial class MainForm : BaseForm
    {
        private TimeTrackerStopWatch _stopwatch = new TimeTrackerStopWatch(new TimeSpan());
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();


        private BindingList<Participant> _allParticipants = new();
        private BindingSource _participantBindingSource = new();

        private bool _notInGoalParticipantFilter => NotInGoalParticipantFilterRadio.Checked;

        public MainForm()
        {
            InitializeComponent();

            // init new comp
            _competition = new Competition();

            AddResultButton.Enabled = false;
            AddResultButton2.Enabled = false;

            // Timer setup (updates every 100 ms)
            _timer.Interval = 100;
            _timer.Tick += Timer_Tick;
            TimerRunningChanged += MainForm_TimerRunningChanged;


            // Init keybindnings
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;


            // Bind result to datagrid
            resultGridView.DataSource = _competition.Results;
            resultGridView.CellValueChanged += ResultGridView_CellValueChanged;

            // Rename columns
            resultGridView.Columns[0].HeaderText = "Resultat";
            resultGridView.Columns["ElapsedTime"].HeaderText = "Tid";
            resultGridView.Columns["ParticipantStartNumber"].HeaderText = "Startnummer";

            resultGridView.Columns["ParticipantName"].HeaderText = "Namn";
            resultGridView.Columns["ParticipantClub"].HeaderText = "Klubb";
            resultGridView.Columns["ParticipantClass"].HeaderText = "Klass";


            resultGridView.Columns["Participant"].Visible = false;
            resultGridView.Columns["ParticipantId"].Visible = false;


            ParticipantDataGridView.DataBindingComplete += ParticipantDataGridView_DataBindingComplete;
            ParticipantDataGridView.CellContentClick += ParticipantDataGridView_CellContentClick;

            NotInGoalParticipantFilterRadio.Checked = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && TimerIsRunning)
            {
                AddResultButton_Click(sender, e);
                e.Handled = true;
            }
        }

        #region Stopwatch

        private StopWatchForm _stopWatchForm;

        private void öppnaTidtagareIEgetFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStopwatch();
        }

        private void ShowStopwatch()
        {
            if (_stopWatchForm == null || _stopWatchForm.IsDisposed)
            {
                _stopWatchForm = new StopWatchForm();
                _stopWatchForm.Show();
            }
            else
            {
                _stopWatchForm.BringToFront();
            }
        }

        private void AdjustTimerButton_Click(object sender, EventArgs e)
        {
            var adjustForm = new SetTimerForm(_stopwatch.Elapsed);

            if (adjustForm.ShowDialog() == DialogResult.OK)
            {
                var newTime = new TimeSpan(adjustForm.Hours, adjustForm.Minutes, adjustForm.Seconds);
                _stopwatch = new TimeTrackerStopWatch(newTime);

                TimerIsRunning = false;
                timerLabel.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            }

        }

        private void MainForm_TimerRunningChanged(object? sender, EventArgs e)
        {
            Debug.WriteLine($"Timer running state changed: {TimerIsRunning}");
            // Add additional UI reactions if needed
            AddResultButton.Enabled = TimerIsRunning;
            AddResultButton2.Enabled = TimerIsRunning;
            StartTimerButton.Text = TimerIsRunning ? "Stoppa Timer" : "Start Timer";

            StartTimerButton.BackColor = TimerIsRunning ? Color.LightSalmon : Color.LightGreen;


            if (TimerIsRunning)
            {
                _stopwatch.Start();
                _timer.Start();
            }
            else
            {
                _timer.Stop();
                _stopwatch.Stop();
            }
        }

        private void StartTimerButton_Click(object sender, EventArgs e)
        {
            if (!TimerIsRunning)
            {
                TimerIsRunning = true;
            }
            else
            {
                TimerIsRunning = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");

            if (_stopWatchForm != null && !_stopWatchForm.IsDisposed)
            {
                _stopWatchForm.UpdateDisplay(timerLabel.Text);
            }
        }

        private void ResetTimerButton_Click(object sender, EventArgs e)
        {
            _stopwatch = new TimeTrackerStopWatch(new TimeSpan());
            timerLabel.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            TimerIsRunning = false;
        }


        #endregion


        #region ResultGrid
        private void AddResultButton_Click(object sender, EventArgs e)
        {
            // Add time to result datagrid
            _competition.AddResult(_stopwatch.Elapsed);
        }

        private void ResultGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Assume column for StartNumber is named "ParticipantStartNumber"
            var grid = sender as DataGridView;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            if (columnName == "ParticipantStartNumber")
            {
                var row = grid.Rows[e.RowIndex];
                if (row.DataBoundItem is Result result)
                {
                    // Lookup the participant in the competition list
                    var participant = _allParticipants
                        .FirstOrDefault(p => p.StartNumber == result.ParticipantStartNumber);

                    if (participant == null)
                    {
                        result.Participant = null;
                        grid.Refresh();
                        return;
                    }

                    if (_competition.Results.Count(r => r.ParticipantStartNumber == participant.StartNumber) > 1)
                    {

                        if (HandleDuplicates(participant, result))
                        {
                            addParticipant();
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }

                    addParticipant();

                    void addParticipant()
                    {
                        participant.Finished = true;
                        result.Participant = participant;

                        FilterParticipants(onlyNotFinished: _notInGoalParticipantFilter);
                        grid.Refresh();
                    }
                }
            }
        }

        private bool HandleDuplicates(Participant participant, Result result)
        {
            DialogResult dr = MessageBox.Show("Deltagaren finns redan i resultatlistan, vill du flytta den hit?",
                 "Finns redan", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    var first = _competition.Results.FirstOrDefault(r => r.ParticipantStartNumber == participant.StartNumber && r.Rank != result.Rank);
                    if (first != default)
                    {
                        first.Participant = null;
                        first.ParticipantStartNumber = 0;
                    }
                    //addParticipant();
                    return true;
                case DialogResult.No:
                    return false;

                default:
                    return false;
            }

        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            FileService fileService = new();
            fileService.SaveResultToExcel(_competition.Results);

        }
        #endregion

        #region Participants

        private void ParticipantDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FinishButtonIfMissing();
        }

        private void FinishButtonIfMissing()
        {
            if (!ParticipantDataGridView.Columns.Contains("FinishButton"))
            {
                var goalButton = new DataGridViewButtonColumn
                {
                    Name = "FinishButton",
                    HeaderText = "",
                    Text = "Deltagare i mål!",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };

                ParticipantDataGridView.Columns.Add(goalButton);
            }
        }

        private void ParticipantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ParticipantDataGridView.Columns[e.ColumnIndex].Name == "FinishButton" && e.RowIndex >= 0)
            {
                var participant = ParticipantDataGridView.Rows[e.RowIndex].DataBoundItem as Participant;
                if (participant != null)
                {
                    participant.Finished = true;
                    _competition.AddResultAndParticipant(_stopwatch.Elapsed, participant);
                }
            }
        }


        private void NotInGoalParticipantFilterRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                FilterParticipants(onlyNotFinished: true);

        }

        private void AllParticipantFilterRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                FilterParticipants(onlyNotFinished: false);

        }

        private void FilterParticipants(bool onlyNotFinished)
        {
            if (!_allParticipants.Any())
            {
                return;
            }

            var filtered = onlyNotFinished
                ? _allParticipants.Where(p => !p.Finished).ToList()
                : _allParticipants.ToList();


            var finishButtonIndex = ParticipantDataGridView.Columns["FinishButton"]?.Index;

            if (finishButtonIndex != null)
            {
                ParticipantDataGridView.Columns.RemoveAt((int)finishButtonIndex);
            }


            _participantBindingSource.DataSource = new BindingList<Participant>(filtered);
            ParticipantDataGridView.DataSource = _participantBindingSource;


            // Hide Id
            ParticipantDataGridView.Columns[0].Visible = false;
        }
        private void loadParticipantButton_Click(object sender, EventArgs e)
        {
            var excelService = new FileService();
            _competition.Participants = excelService.LoadParticipantFromExcel();
            _allParticipants = new BindingList<Participant>(_competition.Participants.ToList());
            FilterParticipants(onlyNotFinished: _notInGoalParticipantFilter);
        }

        #endregion


        #region Databindning

        private void dataBindning()
        {
            _allParticipants = new BindingList<Participant>(_competition.Participants.ToList());
            FilterParticipants(false);

            foreach (var res in _competition.Results)
            {
                var participantInResultList = _allParticipants.FirstOrDefault(p => p.StartNumber == res.ParticipantStartNumber);
                if (participantInResultList == default)
                {
                    continue;
                }

                res.Participant = participantInResultList;
            }

            resultGridView.DataSource = _competition.Results;

            CompetitionNametextBox.Text = _competition.Name;
            CompetitionNumberOfParticpants.Value = _competition.NumberOfParticipants;

            _stopwatch = new TimeTrackerStopWatch(_competition.StopWatchElapsedTime);
            timerLabel.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");

        }

        #endregion

        #region File - Save - Load
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCompetition();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _competition = new Competition();
            dataBindning();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileService fileService = new();

            var loadedFile = fileService.OpenCompetition();

            if (loadedFile == null)
            {

                return;
            }

            _competition = loadedFile;
            TimerIsRunning = false;
            dataBindning();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveCompetition();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion

        private void SaveCompetition()
        {
            _competition.Name = CompetitionNametextBox.Text;
            _competition.NumberOfParticipants = (int)CompetitionNumberOfParticpants.Value;
            _competition.StopWatchElapsedTime = _stopwatch.Elapsed;

            FileService fileService = new();
            fileService.SaveCompetition(_competition);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _timer.Dispose();
            base.OnFormClosed(e);
        }


    }
}
