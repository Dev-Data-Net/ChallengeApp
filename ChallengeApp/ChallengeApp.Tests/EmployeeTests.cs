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
        public void TestLetterUpperAverageValue()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('A');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(93.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void TestLetterLowerAverageValue()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('b');
            employee.AddGrade('b');
            employee.AddGrade('d');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(66.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void TestLetterMinValue()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('b');
            employee.AddGrade('b');
            employee.AddGrade('d');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(40, statistics.Min);
        }
        [Test]
        public void TestLetterMaxValue()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('b');
            employee.AddGrade('b');
            employee.AddGrade('d');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(80, statistics.Max);
        }
    }
}