using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.Utility
{
    public class ErrorLog
    {
        public static void ErrorHandling(Type obj, Exception _ex)
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger(obj);
            //logger.Error(_ex.ToString());
        }

        public ErrorLog()
        { }
        #region LogError
        public static void LogError(string strHeader, string strError, string RootPath = "logs")
        {
            try
            {
                string strPath;
                string strActualError;
                StreamWriter objErrWriter;
                DateTime objDt = DateTime.Now;

                string strDate;
                strDate = objDt.ToString("ddMMyyyy");
                var fpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                // Get Actual Path of "Error" stored in Web.config
                strPath = Path.Combine(fpath, RootPath);
                //Generates Path & LogFile Name of  ErrorLog                

                EnsureDir(new System.IO.DirectoryInfo(strPath));

                strPath = Path.Combine(strPath, strDate + ".log");
                // Generates Error Message
                strActualError = DateTime.Now + " : " + strHeader + " : " + strError;

                // Creation of File.
                objErrWriter = new StreamWriter(strPath, true, System.Text.Encoding.ASCII);

                objErrWriter.WriteLine("");
                objErrWriter.WriteLine(strActualError);
                objErrWriter.Close();
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
        #region EnsureDirectory
        public static void EnsureDir(System.IO.DirectoryInfo oDirInfo)
        {
            if (!oDirInfo.Exists)
            {
                oDirInfo.Create();
            }
        }
        #endregion EnsureDirectory
    }
}
