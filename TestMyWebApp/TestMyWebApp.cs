using MutateX.Controllers;
using NUnit.Framework;

namespace TestMyWebApp
{
    public class Tests
    {
        private string helloWorldText => "Hello World Mutate!";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMyWebApp()
        {
            HomeController homeController = new HomeController();

            var result = homeController.Mutate();

            Assert.AreEqual(helloWorldText, result);

        }
    }
}