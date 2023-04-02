using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MongoDBDatabaseEdit
{
    public class MongoHelper: IMongoHelper
    {
        private string conString = Properties.Settings.Default.CONNECTION_STRING;
        private string dbName = Properties.Settings.Default.DB_NAME;
        public IMongoDatabase GetMongoDbInstance()
        {
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(conString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            MongoClient client = new MongoClient(settings);
            return client.GetDatabase(dbName);
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName) { return GetMongoDbInstance().GetCollection<T>(collectionName); }
        public async Task<List<T>> GetAllDocumentsAsync<T>(string collectionName)
        { 
            var collection = GetCollection<T>(collectionName);
            return await collection.Find(_ => true).ToListAsync();
        }
        public async Task<List<T>> GetFilteredDocuments<T>(string collectionName, FilterDefinition<T> filter) 
        {
            return await GetCollection<T>(collectionName).Find(filter).ToListAsync();
        }
        public async Task UpdateDocument<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> document) 
        {
            await GetCollection<T>(collectionName).UpdateOneAsync(filter, document);
        }
        public async Task CreateDocument<T>(string collectionName, T document) 
        { 
            await GetCollection<T>(collectionName).InsertOneAsync(document); 
        }
        public async Task DeleteDocument<T>(string collectionName, FilterDefinition<T> filter) 
        {
            await GetCollection<T>(collectionName).DeleteOneAsync(filter);
        }

        public Task<List<T>> GetAllDocuments<T>(string collectionName)
        {
            throw new NotImplementedException();
        }
    }
}
