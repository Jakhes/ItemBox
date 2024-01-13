using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ItemLibraray.Models;

namespace ItemLibraray.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Implement the actual connection to the database
        public void Create_Item(ItemModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Items")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Description", model.Description);
                p.Add("@Value", model.Value);
                p.Add("@Lore", model.Lore);
                p.Add("@SysId", model.SystemRefId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spItems_Insert", p,commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");
            }
        }

        public List<ItemModel> GetItems_BySystemId(int p_SystemId)
        {
            List<ItemModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Items")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", p_SystemId);

                output = connection.Query<ItemModel>("dbo.spItems_GetById", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
    }
}
