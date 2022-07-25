using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace YashAksh
{
   public class AppSettings
    {
        Configuration config;
        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string key) 
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void saveConnectionStrings(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "YashAksh.Properties.Settings.MY_DBConnectionString";
            config.Save(ConfigurationSaveMode.Modified);
        }

    }
}
