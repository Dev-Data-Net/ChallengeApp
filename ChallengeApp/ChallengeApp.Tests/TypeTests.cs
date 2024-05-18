namespace ChallengeApp.Tests
{
    public class TypeTests
    {

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




    }
}
