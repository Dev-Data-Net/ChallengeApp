namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void StatisticsAverageTest()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Average);
        }

        [Test]
        public void StatisticsMinTest()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void StatisticsMaxTest()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(4, statistics.Max);
        }
    }
}