using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using DndCharGen.Base.Character.CharacterSheetAccessors;

namespace DndCharGen.Base.SourceData.Races.RaceTraits
{
    public class Trait
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private string description;
        public string Description
        {
            get { return description; }
        }

        private CharacterSheetAccessor characterSheetAccessor;
        public CharacterSheetAccessor CharacterSheetAccessor
        {
            get { return characterSheetAccessor; }
        }

        public Trait(KeyValuePair<string, string> parsedData, CharacterSheetAccessor accessor = null)
        {
            name = parsedData.Key;
            description = parsedData.Value;
            characterSheetAccessor = accessor;
        }
    }
}
