using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.SourceData.Equipment.Weapons
{
    public class Property
    {
        private string name;
        public string Name { get { return name; } }

        public Property(string name)
        {
            this.name = name;
        }
    }
}
