using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void Init_Connections(bool database, bool textFile)
        {
            if (database)
            {
                // TODO - Create Database Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFile)
            {
                // TODO - Create Textfile Connection
                TextFileConnector text = new TextFileConnector();
                Connections.Add(text);
            }
        }
    }
}
