using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class RegistryOperation
    {
        public void StoreValue(string Key, string ExpiryDate)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings");
            object o = key.GetValue("Setting1", null);
            if (o != null)
            {
                key.DeleteValue("Setting1");
                key.DeleteValue("Setting2");
            }
            key.SetValue("Setting1", Key);
            key.SetValue("Setting2", ExpiryDate);
            key.Close();
        }
        public string[] RetrieveValue()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");
            if (key != null)
            {
                string[] ret = { key.GetValue("Setting1").ToString(), key.GetValue("Setting2").ToString() };
                key.Close();
                return ret;
            }
            return null;
        }

        public void ValueExists()
        {
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OurSettings");
            if (key == null)
            {
                // Not exists
            }
            else
            {
                // Exists
            }
        }

        public void ValueExists1()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");


            object o = key.GetValue("Setting1", null);
            if (o != null)

            {

                Console.WriteLine("Value Exists!");

            }

            else

            {

                Console.WriteLine("Value Does Not Exists!");

            }
        }
    }
}
