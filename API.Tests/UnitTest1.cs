using API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;

namespace API.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultGetHelloWorld()
        {
            var controller = new DefaultController();

            var response = controller.Get();
            var contentResult = response as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Hello World", contentResult.Content);
        }
    }
}
