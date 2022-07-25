using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;

namespace App.Service
{
    public class AWSLibrary
    {
        public static string bucketName { get { return "sportsappstorage"; } }
        public static string accessKey { get { return "AKIAU5JAQ2O2TQF2HNOA"; } }
        public static string secretKey { get { return "3HKxIxto3wWdyohSNp4QrkaNxJceHBDo6djHKAkw"; } }

        // Specify your bucket region (an example region is shown).
        private readonly RegionEndpoint bucketRegion = RegionEndpoint.USEast1;
        public IAmazonS3 amazonS3;
        public AWSLibrary()
        {
            amazonS3 = new AmazonS3Client(accessKey, secretKey, bucketRegion);
        }
        public async Task<string> ReadObjectDataAsync(string keyName)
        {
            string responseBody = "";
            try
            {
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName
                };
                using (GetObjectResponse response = await amazonS3.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string title = response.Metadata["x-amz-meta-title"]; // Assume you have "title" as medata added to the object.
                    string contentType = response.Headers["Content-Type"];
                    responseBody = reader.ReadToEnd(); // Now you process the response body.
                    long timeStamp = DateTime.Now.ToFileTime();

                    string filePath = "d://" + timeStamp + ".csv";
                    File.WriteAllText(filePath, responseBody);

                    StreamReader reader2 = null;
                    List<string> listA = new List<string>();
                    List<string> listB = new List<string>();
                    if (File.Exists(filePath))
                    {
                        reader2 = new StreamReader(File.OpenRead(filePath));

                        while (!reader2.EndOfStream)
                        {
                            var line = reader2.ReadLine();
                            var values = line.Split(',');
                            foreach (var item in values)
                            {
                                listA.Add(item);
                            }
                            foreach (var coloumn1 in listA)
                            {
                                listB.Add(coloumn1);
                                Console.WriteLine(coloumn1);
                            }
                        }
                    }

                    //using (var reader2 = new StreamReader(filePath))
                    //{
                    //    List<string> listA = new List<string>();
                    //    List<string> listB = new List<string>();
                    //    while (!reader2.EndOfStream)
                    //    {    
                    //        var line = reader2.ReadLine();
                    //        var values = line.Split(';');

                    //        listA.Add(values[0]);
                    //        listB.Add(values[1]);
                    //    }
                    //}
                }
                return responseBody;
            }
            catch (AmazonS3Exception e)
            {
                return responseBody = e.Message;
            }
            catch (Exception e)
            {
                return responseBody = e.Message;
            }
        }

        public async Task UploadFile(string keyName, string filePath, string contentType)
        {
            string responseBody = "";

            try
            {
                var res = DoesBucketExist(bucketName);
                if (res == true)
                {
                    //// 2. Put the object-set ContentType and add metadata.
                    var putRequest2 = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = keyName,
                        FilePath = filePath,
                        ContentType = contentType
                    };

                    PutObjectResponse response = await amazonS3.PutObjectAsync(putRequest2);
                    if (response != null)
                    {
                        //success
                        responseBody = "Success";
                    }
                }
                else
                {
                    //Bucket not found :(  
                    responseBody = "Bucket not found ";
                }
            }
            catch (Exception e)
            {
                responseBody = e.Message;
            }
        }
        private bool DoesBucketExist(string bucketName)
        {

            if ((AmazonS3Util.DoesS3BucketExist(amazonS3, bucketName)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
