namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoScores()
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




    }
}