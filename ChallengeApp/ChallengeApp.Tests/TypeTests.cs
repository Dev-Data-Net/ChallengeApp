namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        // typ wartościowy
        [Test]
        public void ValueTestTypeString()
        {
            // arrange
            string number1 = "1";
            string number2 = "1";

            // act


            // assert
            Assert.AreEqual(number1, number2);


        }

        [Test]
        public void ValueTestTypeInt()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act


            // assert
            Assert.AreEqual(number1, number2);


        }

        [Test]
        public void ValueTestTypeFloat()
        {
            // arrange
            float number3 = 1.50f;
            float number4 = 1.50f;

            // act


            // assert
            Assert.AreEqual(number3, number4);


        }

        // typ referencyjny
        [Test]
        public void ReferenceTestTypeDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Zbysław");
            var user2 = GetUser("Zbysław");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);


        }
        public void ReferenceTestTypeSameObjects()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreNotEqual(user1.Login, user2.Login);


        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
