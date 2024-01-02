using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray
{
    public interface IDataConnection
    {
        Item Create_Item(Item model);
    }
}
