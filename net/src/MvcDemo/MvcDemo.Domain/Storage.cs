using MongoDB.Driver;

namespace MvcDemo.Domain
{
	public class MongoStorage<T> where T : class 
	{
		private readonly string _collectionName;

		private static MongoClient _client;
		private static MongoConfiguration _configuration;

		static MongoStorage()
		{
			_configuration = new MongoConfiguration();

			_client = new MongoClient(_configuration.GetUrl());
		}

		public MongoStorage(string name)
		{
			_collectionName = name;
		}

		public MongoCollection<T> Get()
		{
			var server = _client.GetServer();
			var database = server.GetDatabase(_configuration.GetDatabaseName());
			
			return database.GetCollection<T>(_collectionName);
		}
	}
}
