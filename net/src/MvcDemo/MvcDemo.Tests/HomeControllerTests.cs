using System.Web.Mvc;
using MvcDemo.Controllers;
using NUnit.Framework;

namespace MvcDemo.Tests
{
	[TestFixture]
	public class HomeControllerTests
    {
		private HomeController _target;

		[SetUp]
		public void Setup()
		{
			_target = new HomeController();
		}
		

		[Test]
		public void Index_WhenCalled_ReturnsMessage()
		{
			var result = _target.Index();

			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public void Status_WhenCalledWithUserName_ReturnUserNameInMessage()
		{
			const string userName = "Yossi";

			var result = _target.Status(userName);

			Assert.That(result, Is.Not.Null);
			Assert.That(result, Is.TypeOf<ContentResult>());
			var content = (ContentResult) result;
			Assert.That(content.Content, Is.StringContaining(userName));
		}
    }
}
