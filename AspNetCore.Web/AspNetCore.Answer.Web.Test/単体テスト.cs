using AspNetCore.Answer.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.Answer.Web.Test
{
    [TestClass]
    public class 単体テスト
    {
        [TestMethod]
        public void 挨拶_11時_おはよう()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(11);

            //Assert
            Assert.AreEqual("おはよう", actual);
        }

        [TestMethod]
        public void 挨拶_12時_こんにちは()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(12);

            //Assert
            Assert.AreEqual("こんにちは", actual);
        }

        [TestMethod]
        public void 挨拶_18時_こんばんは()
        {
            //Arrange
            var service = new HomeService();

            //Act
            var actual = service.Greet(18);

            //Assert
            Assert.AreEqual("こんばんは", actual);
        }

        [TestMethod]
        public void 挨拶_2時_こんばんは()
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
