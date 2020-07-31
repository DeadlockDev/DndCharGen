using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.Character.CharacterSheetAccessors.Conditions
{
    public interface ICondition
    {
        bool Evaluate();
    }
}
