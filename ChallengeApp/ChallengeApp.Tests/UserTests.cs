namespace ChallengeApp.Tests
{
    public class UserTests
    {

        [Test]
        public void WhenUserCollectTwoPositiviesScores()
        {
            // arrange
            var user = new User("Zbigniew", "adsdsdsddas1212");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);

        }

        [Test]
        public void WhenUserCollectTwoNegtivesScores()
        {
            // arrange
            var user = new User("Zbigniew", "adsdsdsddas1212");
            user.AddScore(-5);
            user.AddScore(-6);

            // act
            var result2 = user.Result;

            // assert
            Assert.AreEqual(-11, result2);

        }

        [Test]
        public void TestingVoidPenaltyScore()
        {
            // arrange
            var user = new User("Zbigniew", "adsdsdsddas1212");
            user.PenaltyScore(5);
            user.PenaltyScore(6);

            // act
            var result3 = user.Result;

            // assert
            Assert.AreEqual(-11, result3);

        }
    }
}