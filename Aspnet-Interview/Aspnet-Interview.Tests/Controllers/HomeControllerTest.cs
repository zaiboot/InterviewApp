using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aspnet_Interview.Controllers;

namespace Aspnet_Interview.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

      
    }
}
