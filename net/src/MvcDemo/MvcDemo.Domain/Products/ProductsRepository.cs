using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace MvcDemo.Domain.Products
{
	public class ProductsRepository
	{
		private MongoStorage<ProductDto> _mongoStorage;

		public ProductsRepository()
		{
			_mongoStorage = new MongoStorage<ProductDto>("products");
		}

		public string Add(string description)
		{
			var product = new ProductDto {Description = description};
			_mongoStorage.Get().Insert(product);

			return product.Id.ToString();
		}

		public void Rate(string id, int rate)
		{
			
		}

		public ProductDto GetById(string id)
		{
			return _mongoStorage.Get().AsQueryable().FirstOrDefault(x => x.Id == new ObjectId(id));
		}

		public IList<ProductDto> Query(Expression<Func<ProductDto, bool>> predicate)
		{
			return _mongoStorage.Get().AsQueryable().Where(predicate).ToArray();
		}
	}
}
