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
    }
}
