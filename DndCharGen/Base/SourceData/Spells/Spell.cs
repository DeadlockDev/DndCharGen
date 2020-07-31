using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.SourceData.Spells
{
    public class Spell
    {
        private string spellName;
        public string SpellName { get { return spellName; } }

        private string spellDescription;
        public string SpellDescription { get { return spellDescription; } }

        public Spell(string name, string description)
        {
            spellName = name;
            spellDescription = description;
        }
    }
}
