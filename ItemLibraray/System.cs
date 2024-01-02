using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray
{
    internal class System
    {
        /// <summary>
        /// The System's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents a List of all Items in a cohesive System.
        /// </summary>
        public List<Item> ItemCodex { get; set; } = new List<Item>();

    }
}
