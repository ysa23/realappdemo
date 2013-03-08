using System.Web.Mvc;
using MvcDemo.Domain.Products;

namespace MvcDemo.Controllers
{
	public class ProductsController : Controller
	{
		private readonly ProductsRepository _repository;

		public ProductsController()
		{
			_repository = new ProductsRepository();
		}

		public ActionResult Add(string description)
		{
			var addedProductId = _repository.Add(description);

			return Content(addedProductId);
		}

		public ActionResult Get(string id)
		{
			return Content(_repository.GetById(id).Description);
		}
	}
}