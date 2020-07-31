using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.SourceData.Items.Tools
{
    public class Tool : Item
    {
        public Tool(string name, int cost, int weight) : base(name, cost, weight) { }
    }
}
