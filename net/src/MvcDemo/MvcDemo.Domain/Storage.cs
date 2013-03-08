using MongoDB.Driver;

namespace MvcDemo.Domain
{
	public class MongoStorage<T> where T : class 
	{
		private string _collectionName;

		private static MongoClient _client;

		static MongoStorage()
		{
			_client = new MongoClient(@"mongodb://appharbor:c6c68b4f2545335f2b33efc02833b8fb@linus.mongohq.com:10015/acb33024_76e2_4641_a1be_9b7efaae870e");
		}

		public MongoStorage(string name)
		{
			_collectionName = name;
		}

		public MongoCollection<T> Get()
		{
			var server = _client.GetServer();
			var database = server.GetDatabase("acb33024_76e2_4641_a1be_9b7efaae870e");
			
			return database.GetCollection<T>(_collectionName);
		}
	}
}
