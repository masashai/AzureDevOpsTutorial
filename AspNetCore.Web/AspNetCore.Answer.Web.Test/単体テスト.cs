using AspNetCore.Answer.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.Answer.Web.Test
{
    [TestClass]
    public class ’P‘ÌƒeƒXƒg
    {
        [TestMethod]
        public void ˆ¥ŽA_11Žž_‚¨‚Í‚æ‚¤()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(11);

            //Assert
            Assert.AreEqual("‚¨‚Í‚æ‚¤", actual);
        }

        [TestMethod]
        public void ˆ¥ŽA_12Žž_‚±‚ñ‚É‚¿‚Í()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(12);

            //Assert
            Assert.AreEqual("‚±‚ñ‚É‚¿‚Í", actual);
        }

        [TestMethod]
        public void ˆ¥ŽA_18Žž_‚±‚ñ‚Î‚ñ‚Í()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(18);

            //Assert
            Assert.AreEqual("‚±‚ñ‚Î‚ñ‚Í", actual);
        }

        [TestMethod]
        public void ˆ¥ŽA_2Žž_‚±‚ñ‚Î‚ñ‚Í()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(2);

            //Assert
            Assert.AreEqual("‚±‚ñ‚Î‚ñ‚Í", actual);
        }
    }
}
