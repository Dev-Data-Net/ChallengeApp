namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Jan";

        public string Surname => "Kowalski";

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
