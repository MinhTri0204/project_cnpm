using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DoAn.dao_xu_ly
{
    class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string getConnectionString(string name)
        {
            return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }
        public void setConnectionString(string name, string newvalue)
        {
            config.ConnectionStrings.ConnectionStrings[name].ConnectionString = newvalue;
            config.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
