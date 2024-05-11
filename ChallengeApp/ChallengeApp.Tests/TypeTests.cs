
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TESTs()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");

            // act


            // assert


        }

        private User GetUser(string name)
        {
            return new User("Adam");
        }
    }
}
