using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib
{
    public interface IMongoConfigurationService
    {
        MongoOperationsMode GetOperationMode();
        string GetMongoDatabase();
    }
}