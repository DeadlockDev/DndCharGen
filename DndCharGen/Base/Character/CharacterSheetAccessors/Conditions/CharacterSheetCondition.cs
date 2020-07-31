using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;

namespace DndCharGen.Base.Character.CharacterSheetAccessors.Conditions
{
    public class CharacterSheetCondition
    {
        private ICondition condition;

        public CharacterSheetCondition(ICondition sheetCondition)
        {
            condition = sheetCondition;
        }

        public bool Evaluate()
        {
            return condition.Evaluate();
        }
    }
}
