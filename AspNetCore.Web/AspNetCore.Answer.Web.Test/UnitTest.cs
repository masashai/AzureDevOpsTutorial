using AspNetCore.Answer.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.Answer.Web.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Greet_11_GoodMorning()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(11);

            //Assert
            Assert.AreEqual("おはよう", actual);
        }

        [TestMethod]
        public void Greet_12_Hello()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(12);

            //Assert
            Assert.AreEqual("こんにちは", actual);
        }

        [TestMethod]
        public void Greet_18_GoodEvening()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(18);

            //Assert
            Assert.AreEqual("こんばんは", actual);
        }

        [TestMethod]
        public void Greet_2_GoodEvening()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(2);

            //Assert
            Assert.AreEqual("こんばんは", actual);
        }
    }
}
