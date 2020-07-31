using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.Items;
using DndCharGen.Base.SourceData.Items.Tools;

namespace DndCharGen.Base.SourceData.Races
{
    public class Race
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private List<SubRace> subRaces;
        public List<SubRace> SubRaces
        {
            get { return subRaces; }
        }
    }
}
