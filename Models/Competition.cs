using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    internal class Competition
    {
        public string? Name { get; set; }
        public int NumberOfParticipants { get; set; } = 1;
        public string? Description { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset Updated { get; set; } = DateTimeOffset.UtcNow;
        public List<Participant> Participants { get; set; } = new();
        public int CalculatedNumberOfParticipants => Participants.Count;
        public BindingList<Result> Results { get; set; } = new();

        public TimeSpan StopWatchElapsedTime { get; set; }

        public void AddResult(TimeSpan timeSpan)
        {
            Results.Add(Result.Create(timeSpan, Results.Count + 1));
        }

        public void AddResultAndParticipant(TimeSpan timeSpan, Participant participant)
        {
            var res = Result.Create(timeSpan, Results.Count + 1);
            res.ParticipantStartNumber = participant.StartNumber;
            res.Participant = participant;
            Results.Add(res);
        }

    }
}
