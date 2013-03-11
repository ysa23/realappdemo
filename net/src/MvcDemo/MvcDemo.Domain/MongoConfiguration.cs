using System.Configuration;

namespace MvcDemo.Domain
{
	public class MongoConfiguration
	{
		public string GetUrl()
		{
			return ConfigurationManager.AppSettings["mongo:url"];
		}

		public string GetDatabaseName()
		{
			return ConfigurationManager.AppSettings["mongo:database-name"];
		}
	}
}
