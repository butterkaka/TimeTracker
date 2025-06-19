namespace TimeTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CompetionControlPanel = new GroupBox();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            ParticipantDataGridView = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            NotInGoalParticipantFilterRadio = new RadioButton();
            AllParticipantFilterRadio = new RadioButton();
            loadParticipantButton = new Button();
            timer = new GroupBox();
            OpenStopWatchModalButton = new Button();
            AdjustTimerButton = new Button();
            ResetTimerButton = new Button();
            AddResultButton = new Button();
            timerLabel = new Label();
            StartTimerButton = new Button();
            ControlPanel = new Panel();
            pictureBox1 = new PictureBox();
            CompetitionNumberOfParticpants = new NumericUpDown();
            SaveBtn = new Button();
            CompetitionNametextBox = new TextBox();
            CompetitionNameLabel = new Label();
            NumberOfPartLabel = new Label();
            HorizontalSplitContainer = new SplitContainer();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            VerticalSplitContainer = new SplitContainer();
            panel4 = new Panel();
            resultGridView = new DataGridView();
            panel3 = new Panel();
            saveResultButton = new Button();
            AddResultButton2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            colorDialog1 = new ColorDialog();
            CompetionControlPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ParticipantDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            timer.SuspendLayout();
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompetitionNumberOfParticpants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HorizontalSplitContainer).BeginInit();
            HorizontalSplitContainer.Panel1.SuspendLayout();
            HorizontalSplitContainer.Panel2.SuspendLayout();
            HorizontalSplitContainer.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VerticalSplitContainer).BeginInit();
            VerticalSplitContainer.Panel1.SuspendLayout();
            VerticalSplitContainer.Panel2.SuspendLayout();
            VerticalSplitContainer.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // CompetionControlPanel
            // 
            CompetionControlPanel.AutoSize = true;
            CompetionControlPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CompetionControlPanel.Controls.Add(groupBox1);
            CompetionControlPanel.Controls.Add(timer);
            CompetionControlPanel.Controls.Add(ControlPanel);
            CompetionControlPanel.Dock = DockStyle.Fill;
            CompetionControlPanel.Location = new Point(5, 6);
            CompetionControlPanel.Margin = new Padding(5, 6, 5, 6);
            CompetionControlPanel.MaximumSize = new Size(750, 0);
            CompetionControlPanel.MinimumSize = new Size(750, 0);
            CompetionControlPanel.Name = "CompetionControlPanel";
            CompetionControlPanel.Padding = new Padding(10, 11, 10, 11);
            CompetionControlPanel.Size = new Size(750, 817);
            CompetionControlPanel.TabIndex = 0;
            CompetionControlPanel.TabStop = false;
            CompetionControlPanel.Text = "Tävling";
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(10, 438);
            groupBox1.Margin = new Padding(3, 11, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 11, 10, 11);
            groupBox1.Size = new Size(730, 368);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deltagare";
            // 
            // panel5
            // 
            panel5.Controls.Add(ParticipantDataGridView);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(710, 285);
            panel5.TabIndex = 6;
            // 
            // ParticipantDataGridView
            // 
            ParticipantDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ParticipantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ParticipantDataGridView.Dock = DockStyle.Fill;
            ParticipantDataGridView.Location = new Point(0, 0);
            ParticipantDataGridView.Margin = new Padding(3, 23, 3, 3);
            ParticipantDataGridView.Name = "ParticipantDataGridView";
            ParticipantDataGridView.Size = new Size(710, 285);
            ParticipantDataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(loadParticipantButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 43);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(NotInGoalParticipantFilterRadio);
            panel1.Controls.Add(AllParticipantFilterRadio);
            panel1.Location = new Point(560, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 29);
            panel1.TabIndex = 3;
            // 
            // NotInGoalParticipantFilterRadio
            // 
            NotInGoalParticipantFilterRadio.AutoSize = true;
            NotInGoalParticipantFilterRadio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotInGoalParticipantFilterRadio.Location = new Point(61, 2);
            NotInGoalParticipantFilterRadio.Name = "NotInGoalParticipantFilterRadio";
            NotInGoalParticipantFilterRadio.Size = new Size(68, 21);
            NotInGoalParticipantFilterRadio.TabIndex = 2;
            NotInGoalParticipantFilterRadio.TabStop = true;
            NotInGoalParticipantFilterRadio.Text = "Ej i mål";
            NotInGoalParticipantFilterRadio.UseVisualStyleBackColor = true;
            NotInGoalParticipantFilterRadio.CheckedChanged += NotInGoalParticipantFilterRadio_CheckedChanged;
            // 
            // AllParticipantFilterRadio
            // 
            AllParticipantFilterRadio.AutoSize = true;
            AllParticipantFilterRadio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllParticipantFilterRadio.Location = new Point(10, 3);
            AllParticipantFilterRadio.Name = "AllParticipantFilterRadio";
            AllParticipantFilterRadio.Size = new Size(47, 21);
            AllParticipantFilterRadio.TabIndex = 1;
            AllParticipantFilterRadio.TabStop = true;
            AllParticipantFilterRadio.Text = "Alla";
            AllParticipantFilterRadio.UseVisualStyleBackColor = true;
            AllParticipantFilterRadio.CheckedChanged += AllParticipantFilterRadio_CheckedChanged;
            // 
            // loadParticipantButton
            // 
            loadParticipantButton.AutoSize = true;
            loadParticipantButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadParticipantButton.BackColor = SystemColors.Control;
            loadParticipantButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadParticipantButton.Location = new Point(9, 8);
            loadParticipantButton.Name = "loadParticipantButton";
            loadParticipantButton.Size = new Size(111, 27);
            loadParticipantButton.TabIndex = 4;
            loadParticipantButton.Text = "Läs in deltagare";
            loadParticipantButton.UseVisualStyleBackColor = false;
            loadParticipantButton.Click += loadParticipantButton_Click;
            // 
            // timer
            // 
            timer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer.Controls.Add(OpenStopWatchModalButton);
            timer.Controls.Add(AdjustTimerButton);
            timer.Controls.Add(ResetTimerButton);
            timer.Controls.Add(AddResultButton);
            timer.Controls.Add(timerLabel);
            timer.Controls.Add(StartTimerButton);
            timer.Dock = DockStyle.Top;
            timer.Location = new Point(10, 100);
            timer.Margin = new Padding(8, 9, 8, 9);
            timer.Name = "timer";
            timer.Size = new Size(730, 338);
            timer.TabIndex = 8;
            timer.TabStop = false;
            timer.Text = "Timer";
            // 
            // OpenStopWatchModalButton
            // 
            OpenStopWatchModalButton.Location = new Point(681, 22);
            OpenStopWatchModalButton.Name = "OpenStopWatchModalButton";
            OpenStopWatchModalButton.Size = new Size(31, 23);
            OpenStopWatchModalButton.TabIndex = 10;
            OpenStopWatchModalButton.Text = "+";
            OpenStopWatchModalButton.UseVisualStyleBackColor = true;
            OpenStopWatchModalButton.Click += OpenStopWatchModalButton_Click;
            // 
            // AdjustTimerButton
            // 
            AdjustTimerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdjustTimerButton.Location = new Point(396, 210);
            AdjustTimerButton.Name = "AdjustTimerButton";
            AdjustTimerButton.Size = new Size(133, 37);
            AdjustTimerButton.TabIndex = 9;
            AdjustTimerButton.Text = "Ställ timer";
            AdjustTimerButton.UseVisualStyleBackColor = true;
            AdjustTimerButton.Click += AdjustTimerButton_Click;
            // 
            // ResetTimerButton
            // 
            ResetTimerButton.BackColor = Color.Silver;
            ResetTimerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetTimerButton.Location = new Point(268, 210);
            ResetTimerButton.Name = "ResetTimerButton";
            ResetTimerButton.Size = new Size(110, 37);
            ResetTimerButton.TabIndex = 8;
            ResetTimerButton.Text = "Nollställ";
            ResetTimerButton.UseVisualStyleBackColor = false;
            ResetTimerButton.Click += ResetTimerButton_Click;
            // 
            // AddResultButton
            // 
            AddResultButton.BackColor = Color.Turquoise;
            AddResultButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddResultButton.Location = new Point(123, 254);
            AddResultButton.Name = "AddResultButton";
            AddResultButton.Size = new Size(406, 61);
            AddResultButton.TabIndex = 7;
            AddResultButton.Text = "Registrera tid (tryck space)";
            AddResultButton.UseVisualStyleBackColor = false;
            AddResultButton.Click += AddResultButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Arial", 90F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(7, 37);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(692, 134);
            timerLabel.TabIndex = 6;
            timerLabel.Text = "00:00:00.00";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartTimerButton
            // 
            StartTimerButton.BackColor = Color.LightGreen;
            StartTimerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartTimerButton.Location = new Point(123, 210);
            StartTimerButton.Name = "StartTimerButton";
            StartTimerButton.Size = new Size(126, 37);
            StartTimerButton.TabIndex = 5;
            StartTimerButton.Text = "Starta Timer";
            StartTimerButton.UseVisualStyleBackColor = false;
            StartTimerButton.Click += StartTimerButton_Click;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(pictureBox1);
            ControlPanel.Controls.Add(CompetitionNumberOfParticpants);
            ControlPanel.Controls.Add(SaveBtn);
            ControlPanel.Controls.Add(CompetitionNametextBox);
            ControlPanel.Controls.Add(CompetitionNameLabel);
            ControlPanel.Controls.Add(NumberOfPartLabel);
            ControlPanel.Dock = DockStyle.Top;
            ControlPanel.Location = new Point(10, 29);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(730, 71);
            ControlPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(673, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // CompetitionNumberOfParticpants
            // 
            CompetitionNumberOfParticpants.Location = new Point(317, 16);
            CompetitionNumberOfParticpants.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CompetitionNumberOfParticpants.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CompetitionNumberOfParticpants.Name = "CompetitionNumberOfParticpants";
            CompetitionNumberOfParticpants.Size = new Size(179, 25);
            CompetitionNumberOfParticpants.TabIndex = 4;
            CompetitionNumberOfParticpants.Tag = "Num";
            CompetitionNumberOfParticpants.ThousandsSeparator = true;
            CompetitionNumberOfParticpants.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(515, 16);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 26);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Spara";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CompetitionNametextBox
            // 
            CompetitionNametextBox.Location = new Point(56, 16);
            CompetitionNametextBox.Name = "CompetitionNametextBox";
            CompetitionNametextBox.Size = new Size(179, 25);
            CompetitionNametextBox.TabIndex = 0;
            // 
            // CompetitionNameLabel
            // 
            CompetitionNameLabel.AutoSize = true;
            CompetitionNameLabel.Location = new Point(10, 19);
            CompetitionNameLabel.Name = "CompetitionNameLabel";
            CompetitionNameLabel.Size = new Size(43, 17);
            CompetitionNameLabel.TabIndex = 1;
            CompetitionNameLabel.Text = "Namn";
            // 
            // NumberOfPartLabel
            // 
            NumberOfPartLabel.AutoSize = true;
            NumberOfPartLabel.Location = new Point(254, 19);
            NumberOfPartLabel.Name = "NumberOfPartLabel";
            NumberOfPartLabel.Size = new Size(65, 17);
            NumberOfPartLabel.TabIndex = 3;
            NumberOfPartLabel.Text = "Deltagare";
            // 
            // HorizontalSplitContainer
            // 
            HorizontalSplitContainer.Dock = DockStyle.Fill;
            HorizontalSplitContainer.FixedPanel = FixedPanel.Panel1;
            HorizontalSplitContainer.IsSplitterFixed = true;
            HorizontalSplitContainer.Location = new Point(0, 0);
            HorizontalSplitContainer.Name = "HorizontalSplitContainer";
            HorizontalSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // HorizontalSplitContainer.Panel1
            // 
            HorizontalSplitContainer.Panel1.Controls.Add(menuStrip1);
            // 
            // HorizontalSplitContainer.Panel2
            // 
            HorizontalSplitContainer.Panel2.BackColor = SystemColors.Control;
            HorizontalSplitContainer.Panel2.Controls.Add(VerticalSplitContainer);
            HorizontalSplitContainer.Size = new Size(1384, 862);
            HorizontalSplitContainer.SplitterDistance = 28;
            HorizontalSplitContainer.SplitterWidth = 5;
            HorizontalSplitContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1384, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // VerticalSplitContainer
            // 
            VerticalSplitContainer.Dock = DockStyle.Fill;
            VerticalSplitContainer.Location = new Point(0, 0);
            VerticalSplitContainer.Name = "VerticalSplitContainer";
            // 
            // VerticalSplitContainer.Panel1
            // 
            VerticalSplitContainer.Panel1.BackColor = SystemColors.Control;
            VerticalSplitContainer.Panel1.Controls.Add(CompetionControlPanel);
            VerticalSplitContainer.Panel1.ForeColor = SystemColors.Desktop;
            VerticalSplitContainer.Panel1.Padding = new Padding(5, 6, 5, 6);
            // 
            // VerticalSplitContainer.Panel2
            // 
            VerticalSplitContainer.Panel2.Controls.Add(panel4);
            VerticalSplitContainer.Panel2.Controls.Add(panel3);
            VerticalSplitContainer.Size = new Size(1384, 829);
            VerticalSplitContainer.SplitterDistance = 761;
            VerticalSplitContainer.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(resultGridView);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(619, 766);
            panel4.TabIndex = 5;
            // 
            // resultGridView
            // 
            resultGridView.AllowUserToAddRows = false;
            resultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resultGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            resultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGridView.Dock = DockStyle.Fill;
            resultGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
            resultGridView.Location = new Point(0, 0);
            resultGridView.Name = "resultGridView";
            resultGridView.Size = new Size(619, 766);
            resultGridView.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(saveResultButton);
            panel3.Controls.Add(AddResultButton2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 766);
            panel3.Name = "panel3";
            panel3.Size = new Size(619, 63);
            panel3.TabIndex = 4;
            // 
            // saveResultButton
            // 
            saveResultButton.BackColor = SystemColors.Control;
            saveResultButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveResultButton.Location = new Point(143, 9);
            saveResultButton.Name = "saveResultButton";
            saveResultButton.Size = new Size(134, 44);
            saveResultButton.TabIndex = 1;
            saveResultButton.Text = "Spara resultat (xlsx)";
            saveResultButton.UseVisualStyleBackColor = false;
            saveResultButton.Click += saveResultButton_Click;
            // 
            // AddResultButton2
            // 
            AddResultButton2.BackColor = Color.Turquoise;
            AddResultButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddResultButton2.Location = new Point(6, 10);
            AddResultButton2.Name = "AddResultButton2";
            AddResultButton2.Size = new Size(130, 43);
            AddResultButton2.TabIndex = 2;
            AddResultButton2.Text = "Registrera tid";
            AddResultButton2.UseVisualStyleBackColor = false;
            AddResultButton2.Click += AddResultButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 862);
            Controls.Add(HorizontalSplitContainer);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "TimeTracker";
            CompetionControlPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ParticipantDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            timer.ResumeLayout(false);
            timer.PerformLayout();
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompetitionNumberOfParticpants).EndInit();
            HorizontalSplitContainer.Panel1.ResumeLayout(false);
            HorizontalSplitContainer.Panel1.PerformLayout();
            HorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HorizontalSplitContainer).EndInit();
            HorizontalSplitContainer.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            VerticalSplitContainer.Panel1.ResumeLayout(false);
            VerticalSplitContainer.Panel1.PerformLayout();
            VerticalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VerticalSplitContainer).EndInit();
            VerticalSplitContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox CompetionControlPanel;
        private GroupBox timer;
        private Label timerLabel;
        private Button StartTimerButton;
        private NumericUpDown CompetitionNumberOfParticpants;
        private Label NumberOfPartLabel;
        private Label CompetitionNameLabel;
        private TextBox CompetitionNametextBox;
        private SplitContainer HorizontalSplitContainer;
        private SplitContainer VerticalSplitContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button SaveBtn;
        private Panel ControlPanel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridView resultGridView;
        private Button AddResultButton;
        private GroupBox groupBox1;
        private DataGridView ParticipantDataGridView;
        private RadioButton AllParticipantFilterRadio;
        private RadioButton NotInGoalParticipantFilterRadio;
        private Panel panel1;
        private Button loadParticipantButton;
        private Button saveResultButton;
        private Button AddResultButton2;
        private Panel panel2;
        private Button ResetTimerButton;
        private Button AdjustTimerButton;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button OpenStopWatchModalButton;
    }
}
