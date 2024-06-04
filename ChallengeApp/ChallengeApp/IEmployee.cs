namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        Statistics GetStatistics();
    }
}
