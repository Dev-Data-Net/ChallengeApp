
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        // typ wartościowy
        [Test]
        public void TEST()
        {
            // arrange
            int number1 = 1;
            int number2 = 13;

            // act


            // assert
            Assert.AreEqual(number1, number2);


        }

        // typ referencyjny
        [Test]
        public void DifferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);


        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
