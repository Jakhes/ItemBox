using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibraray.Models;

namespace ItemLibraray.DataAccess
{
    public interface IDataConnection
    {
        void Create_Item(ItemModel model);
        List<ItemModel> GetItems_ById(int p_SystemId);
    }
}
