using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDatabaseEdit
{
    public interface IMongoHelper
    {
        Task<List<T>> GetAllDocuments<T>(string collectionName);
        Task<List<T>> GetFilteredDocuments<T>(string collectionName, FilterDefinition<T> filter);
        Task UpdateDocument<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> document);
        Task CreateDocument<T>(string collectionName, T document);
        Task DeleteDocument<T>(string collectionName, FilterDefinition<T> filter);
    }
}
