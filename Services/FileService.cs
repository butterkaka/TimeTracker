using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TimeTracker.Models;

namespace TimeTracker.Services
{
    internal class FileService
    {
        public List<Participant> LoadParticipantFromExcel()
        {

            var participants = new List<Participant>();

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    using var workbook = new XLWorkbook(filePath);
                    var worksheet = workbook.Worksheets.First(); // use first sheet

                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // skip header

                    if (!rows.Any())
                    {
                        MessageBox.Show($"Inga deltagare i filen");
                    }


                    foreach (var row in rows)
                    {
                        int startNumber = row.Cell(1).GetValue<int>();
                        string name = row.Cell(2).GetString();
                        string club = row.Cell(3).GetString();
                        //var participantClass = Enum.Parse<ParticipantClass>(row.Cell(4).GetString(), true);
                        string participantClass = row.Cell(4).GetString();

                        participants.Add(
                            Participant.Create(name, club, startNumber, 0, participantClass)
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fel vid läsning av filen: {ex.Message}");
                }
            }

            return participants;
        }

        public bool SaveResultToExcel(BindingList<Result> results)
        {
            if (!results.Any())
            {
                MessageBox.Show($"Inget reslutat ännu");
                return false;
            }

            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Spara resultat",
                Filter = "Excel Files|*.xlsx",
                DefaultExt = "xlsx",
                FileName = $"resultat.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Resultat");

                // Headers
                worksheet.Cell(1, 1).Value = "Placering";
                worksheet.Cell(1, 2).Value = "Startnummer";
                worksheet.Cell(1, 3).Value = "Namn";
                worksheet.Cell(1, 4).Value = "Klubb";
                worksheet.Cell(1, 5).Value = "Klass";
                worksheet.Cell(1, 6).Value = "Tid";

                // Data
                int row = 2;
                foreach (var result in results)
                {
                    worksheet.Cell(row, 1).Value = result.Rank;
                    worksheet.Cell(row, 2).Value = result.ParticipantStartNumber;
                    worksheet.Cell(row, 3).Value = result.ParticipantName;
                    worksheet.Cell(row, 4).Value = result.ParticipantClub;
                    worksheet.Cell(row, 5).Value = result.ParticipantClass;
                    worksheet.Cell(row, 6).Value = result.ElapsedTime;
                    row++;
                }

                workbook.SaveAs(saveFileDialog.FileName);
                return true;
            }


            return false;
        }


        #region Competition
        public bool SaveCompetition(Competition competition)
        {

            if (string.IsNullOrEmpty(competition.Name))
            {
                MessageBox.Show("Tävlingen saknar namn");
                return false;
            }

            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Spara tävling",
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json",
                FileName = $"{competition.Name}.json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true, // Makes the JSON more readable
                        ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles // Prevents issues with circular references
                    };

                    string json = JsonSerializer.Serialize(competition, options);
                    File.WriteAllText(saveFileDialog.FileName, json, UTF8Encoding.UTF8);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fel vid försök att spara: {ex.Message}");
                    return false;
                }
            }

            return false;
        }

        public Competition? OpenCompetition()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json Files|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                var jsonStr = File.ReadAllText(filePath);

                var competition = JsonSerializer.Deserialize<Competition>(jsonStr);
                return competition;
            }

            return null;
        }
        #endregion
    }
}
