using System.IO;
using System.Threading.Tasks;

namespace TNG.Shared.Lib.Intefaces
{
    public interface IS3Layer
    {
        bool UploadObject(Stream stream, string contentFolder, string fileName);
        public bool UploadFile(Stream stream, string contentFolder, string fileName);
        Task<string> ReadObjectData(string keyName, string subDirectoryInBucket);
        Task<string> ReadObjectDataBase64(string keyName, string subDirectoryInBucket);
        bool UploadDocumentObject(Stream stream, string contentFolder, string fileName, string type);
    }
}