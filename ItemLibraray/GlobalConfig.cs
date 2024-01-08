using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibraray.DataAccess;
namespace ItemLibraray
{
    public static class GlobalConfig
    {
        public const string ItemsFile = "ItemModels.csv";
        public static IDataConnection Connection { get; private set; }

        public static void Init_Connections(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                // TODO - Create Database Connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            if (db == DatabaseType.Text)
            {
                // TODO - Create Textfile Connection
                TextFileConnector text = new TextFileConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
