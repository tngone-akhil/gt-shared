using System.Collections.Generic;
using MongoDB.Driver;

namespace TNG.Shared.Lib.Intefaces
{
    public interface IMongoLayer
    {

        List<T> LoadAll<T>(string collectionName);
        void InsertDocument<T>(string collectionName, T document);
        void InsertManyDocument<T>(string collectionName, List<T> document);
        T LoadDocumentById<T>(string collectionName, string id);
        List<T> LoadDocuments<T>(string collectionName, FilterDefinition<T> filter, int? limit = 100, SortDefinition<T> sort = null, int? skip = null);
        List<T> LoadListOfDocuments<T>(string collectionName, FilterDefinition<T> filter, SortDefinition<T> sort = null);
        void UpdateDocument<T>(string collectionName, T document);
        void UpdateOrInsertDocument<T>(string collectionName, T document);
        void DeleteDocument<T>(string collectionName, T document);
        void DeleteDocument<T>(string collectionName, FilterDefinition<T> filter);
        T GetLastDoc<T>(string collectionName, FilterDefinition<T> filter = null);
        long GetCount<T>(string collectionName, FilterDefinition<T> filter = null);
        void UpdateDocumentWithOutOperationFilter<T>(string collectionName, T document);

    }
}