using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibraray.Models;
using ItemLibraray.DataAccess.TextHelpers;

namespace ItemLibraray.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
        

        // TODO - Implement the actual connection to the Textfile
        public void Create_Item(ItemModel p_Model)
        {
            // load TExtfile
            // convert to List<ItemModel>
            List<ItemModel> items = GlobalConfig.ItemsFile.fullFilePath().LoadFile().ConvertToItemModels();

            // find max ID
            int currentId = 1;

            if (items.Count > 0)
            {
                currentId = items.OrderByDescending(x => x.ID).First().ID + 1;
            }
            p_Model.ID = currentId;

            // add new record with new id (max + 1)
            items.Add(p_Model);

            // convert items to list<string>
            // save the list<string> to text file
            items.SaveToItemFile();
        }

        public List<ItemModel> GetItems_ById(int p_SystemId)
        {
            throw new NotImplementedException();
        }
    }
}
