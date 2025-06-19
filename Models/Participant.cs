namespace TimeTracker.Models
{
    internal record Participant(Guid Id, string Name, string Club, int StartNumber, int Age, string ParticipantClass)
    {
        public bool Finished { get; set; } = false;

        public static Participant Create(string name,
            string club,
            int startNumber,
            int age,
            string participantClass) => new(Guid.NewGuid(), name, club, startNumber, age, participantClass);
    }
}
