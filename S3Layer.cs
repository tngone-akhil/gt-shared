using Amazon.S3;
using Amazon.S3.Model;
using TNG.Shared.Lib.Intefaces;
using TNG.Shared.Lib.Mongo.Master;

namespace TNG.Shared.Lib
{
    public class S3Layer : IS3Layer
    {
        private S3LayerSettings _s3LayerSetting;
        private AmazonS3Client _client;
        public S3Layer(S3LayerSettings s3LayerSettings)
        {
            this._s3LayerSetting = s3LayerSettings;
            this._client = new AmazonS3Client(s3LayerSettings.accessKeyId, s3LayerSettings.accessSecretKey, Amazon.RegionEndpoint.USEast1);

        }

        /// <summary>
        /// for uploading image
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="clientFolder"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool UploadObject(Stream stream, string contentFolder, string fileName)
        {
            string newFolderName = string.Empty;
            try
            {
                var request = new PutObjectRequest();
                request.BucketName = string.Concat(this._s3LayerSetting.bucket, @"/", contentFolder);
                request.Key = fileName;
                request.InputStream = stream;
                request.ContentType = "image/png";
                request.CannedACL = S3CannedACL.PublicRead;
                var response = this._client.PutObjectAsync(request);
                response.Wait();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UploadDocumentObject(Stream stream, string contentFolder, string fileName, string type)

        {
            string newFolderName = string.Empty;
            try
            {

                var request = new PutObjectRequest();
                request.BucketName = string.Concat(this._s3LayerSetting.bucket, @"/", contentFolder);
                request.Key = fileName;
                request.InputStream = stream;
                if (type == ".pdf")
                {
                    request.ContentType = "application/pdf";
                }
                else if (type == ".doc")

                {
                    request.ContentType = "application/msword";
                }
                else if (type == ".jpg")
                {
                    request.ContentType = "image/jpeg";
                }
                else if (type == ".png")
                {
                    request.ContentType = "image/png";
                }
                else if (type == ".docx")
                {
                    request.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                }

                request.CannedACL = S3CannedACL.PublicRead;

                var response = this._client.PutObjectAsync(request);

                response.Wait();

                return true;

            }

            catch

            {

                return false;

            }

        }

        public bool UploadFile(Stream stream, string contentFolder, string fileName)
        {
            string newFolderName = string.Empty;
            try
            {
                var request = new PutObjectRequest();
                request.BucketName = string.Concat(this._s3LayerSetting.bucket, @"/", contentFolder);
                request.Key = fileName;
                request.InputStream = stream;
                request.ContentType = "application/pdf";
                request.CannedACL = S3CannedACL.PublicRead;
                var response = this._client.PutObjectAsync(request);
                response.Wait();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// to check the folder exist
        /// </summary>
        /// <param name="subDirectoryInBucket"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        private int doesFolderExist(string subDirectoryInBucket, AmazonS3Client client)
        {
            try
            {
                ListObjectsRequest request = new ListObjectsRequest();
                request.BucketName = this._s3LayerSetting.bucket;
                request.Prefix = (subDirectoryInBucket + "/");
                request.MaxKeys = 1;
                var response = client.ListObjectsAsync(request);
                response.Wait();
                var n = response.Result.S3Objects.Count;
                return n;
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// for creating new folder
        /// </summary>
        /// <param name="subDirectoryInBucket"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        private bool createFolder(string subDirectoryInBucket, AmazonS3Client client)
        {
            var folderKey = subDirectoryInBucket + "/"; //end the folder name with "/"
            var request = new PutObjectRequest();
            request.BucketName = this._s3LayerSetting.bucket;
            request.StorageClass = S3StorageClass.Standard;
            request.ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
            request.CannedACL = S3CannedACL.BucketOwnerFullControl;
            request.Key = folderKey;
            request.ContentBody = string.Empty;
            var response = client.PutObjectAsync(request);
            response.Wait();
            return true;
        }

        /// <summary>
        /// for retrieving object 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="subDirectoryInBucket"></param>
        /// <returns></returns>
        public async Task<string> ReadObjectData(string keyName, string subDirectoryInBucket)
        {

            string responseBody = "";
            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = this._s3LayerSetting.bucket + @"/" + subDirectoryInBucket,
                    Key = keyName
                };
                using (GetObjectResponse response = await this._client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string contentType = response.Headers["Content-Type"];
                    responseBody = reader.ReadToEnd();
                    // byte[] imageDataBytes = Encoding.ASCII.GetBytes(responseBody);
                    // responseBody = Convert.ToBase64String(imageDataBytes);
                }
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        public async Task<string> ReadObjectDataBase64(string keyName, string subDirectoryInBucket)
        {

            string responseBody = "";
            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = this._s3LayerSetting.bucket + @"/" + subDirectoryInBucket,
                    Key = keyName
                };
                using (GetObjectResponse response = await this._client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (var memoryStream = new MemoryStream())
                {
                    responseStream.CopyTo(memoryStream);
                    byte[] imageBytes = memoryStream.ToArray();

                    // Convert the image data to base64
                    responseBody = Convert.ToBase64String(imageBytes);

                    // Now, responseBody contains the base64 representation of the image
                }
                return responseBody;
            }
            catch
            {
                return null;
            }
        }


    }
}