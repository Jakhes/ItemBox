using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Implement the actual connection to the database
        public Item Create_Item(Item model)
        {
            model.ID = 1;

            return model;
        }
    }
}
