using System.Collections.Generic;
using MongoDB.Bson;

namespace MvcDemo.Domain
{
	public class ProductDto
	{
		public ObjectId Id { get; set; }
		public string Description { get; set; }
		public IList<int> Ratings { get; set; }
	}
}
