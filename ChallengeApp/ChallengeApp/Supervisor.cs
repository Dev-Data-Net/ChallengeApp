namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Jan";

        public string Surname => "Kowalski";

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
