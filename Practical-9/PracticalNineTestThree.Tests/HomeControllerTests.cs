using PracticalNine.Controllers;
using Xunit;
using System.Web.Mvc;

namespace PracticalNineTestThree.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void TestThree_ReturnsMessage()
        {
            var controller = new HomeController();

            var result = controller.TestThree() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Hello World", result.ViewBag.Message);
        }
    }
}
