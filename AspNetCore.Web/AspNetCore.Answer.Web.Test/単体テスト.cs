using AspNetCore.Answer.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.Answer.Web.Test
{
    [TestClass]
    public class �P�̃e�X�g
    {
        [TestMethod]
        public void ���A_11��_���͂悤()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(11);

            //Assert
            Assert.AreEqual("���͂悤", actual);
        }

        [TestMethod]
        public void ���A_12��_����ɂ���()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(12);

            //Assert
            Assert.AreEqual("����ɂ���", actual);
        }

        [TestMethod]
        public void ���A_18��_����΂��()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(18);

            //Assert
            Assert.AreEqual("����΂��", actual);
        }

        [TestMethod]
        public void ���A_2��_����΂��()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(2);

            //Assert
            Assert.AreEqual("����΂��", actual);
        }
    }
}
