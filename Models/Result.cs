using System.Text.Json.Serialization;

namespace TimeTracker.Models
{
    internal class Result
    {
        public int Rank { get; set; }
        public Result() { }
        public Result(int rank, TimeSpan timeSpan)
        {
            Rank = rank;
            TimeSpan = timeSpan;
        }


        [JsonIgnore]
        public Guid? ParticipantId { get; set; }

        [JsonIgnore]
        public virtual Participant? Participant { get; set; }
        public int ParticipantStartNumber { get; set; }
        public string ParticipantName => Participant?.Name ?? "";
        public string ParticipantClub => Participant?.Club ?? "";

        public string? ParticipantClass => Participant?.ParticipantClass ?? "";
        public string ElapsedTime { get; set; } = "";



        [JsonIgnore]
        public TimeSpan TimeSpan
        {
            get => TimeSpan.TryParseExact(ElapsedTime, @"hh\:mm\:ss", null, out var result) ? result : default;
            set => ElapsedTime = value.ToString(@"hh\:mm\:ss");
        }

        public static Result Create(TimeSpan timeSpan, int rank) => new Result(rank, timeSpan);
    }
}
