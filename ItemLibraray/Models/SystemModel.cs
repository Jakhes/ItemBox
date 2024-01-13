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
        public string SystemName { get; set; }

        /// <summary>
        /// Represents a List of all Items in a cohesive System.
        /// </summary>
        

        public SystemModel()
        {
            ID = 0;
            SystemName = "";
        }
        public SystemModel(string p_Id, string p_Name)
        {
            int idValue = 0;
            int.TryParse(p_Id, out idValue);
            ID = idValue;
            SystemName = p_Name;
        }

        

    }
}
