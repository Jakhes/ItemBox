using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray.Models
{
    internal class SystemModel
    {
        /// <summary>
        /// The System's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents a List of all Items in a cohesive System.
        /// </summary>
        public List<ItemModel> ItemCodex { get; set; } = new List<ItemModel>();

    }
}
