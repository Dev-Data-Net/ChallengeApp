namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsAverageTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Average);
        }

        [Test]
        public void StatisticsAverageRoundTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }


        [Test]
        public void StatisticsMinTest()
        {
            // arrange
            var employee = new Employee();
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
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(4, statistics.Max);
        }

        [Test]
        public void AverageTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(70);
            employee.AddGrade(80);
            employee.AddGrade(75);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(75, statistics.Average);
        }
    }
}