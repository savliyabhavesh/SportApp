using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class CommonOperation
    {
        public static string BackupDb(string filepath, string Bucketpath)
        {
            string responseBody = "";
            try
            {
                bool checknet = chk_con();
                if (checknet)
                {
                    string savepath = filepath + "\\DB\\" + DateTime.Now.ToString("dd MMMM, yyyy hh mm tt") + ".zip";
                    string[] directoryFiles = System.IO.Directory.GetFiles(filepath + "\\DB", "*.zip");
                    foreach (string file in directoryFiles)
                    {
                        File.Delete(file);
                    }
                    using (ZipFile zip = new ZipFile())
                    {
                        zip.AddFile($"{filepath}\\DB\\{BaseService.DbName}", "");
                        zip.Save(savepath);
                    }
                    AWSLibrary aWS = new AWSLibrary();

                    var response = aWS.UploadFile($"{Bucketpath}/{DateTime.Now.ToString("dd MMMM, yyyy hh mm tt")}.zip", savepath, "application/zip");
                    if (response != null)
                    {
                        //success
                        responseBody = "Database Backup successful";
                    }
                    else
                    {
                        //Bucket not found :(  
                        responseBody = "Database Backup Failed";
                    }
                }
                else
                {
                    responseBody = "Please Check Internet Connection";
                }
            }
            catch (Exception ex)
            {
            }
            return responseBody;
        }
        public static bool chk_con()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
