using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray.Models
{
    public class SystemModel
    {
        /// <summary>
        /// The unique Id for this system.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The System's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents a List of all Items in a cohesive System.
        /// </summary>
        public List<ItemModel> ItemCodex { get; set; } = new List<ItemModel>();

        public SystemModel()
        {
            ID = 0;
            Name = "";
            ItemCodex = new List<ItemModel>();
        }
        public SystemModel(string p_Id, string p_Name)
        {
            int idValue = 0;
            int.TryParse(p_Id, out idValue);
            ID = idValue;
            Name = p_Name;
            ItemCodex = new List<ItemModel>();
        }

    }
}
