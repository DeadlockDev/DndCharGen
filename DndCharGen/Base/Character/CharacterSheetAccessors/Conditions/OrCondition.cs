using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.Character.CharacterSheetAccessors.Conditions
{
    public class OrCondition : ICondition
    {
        private ICondition left;
        private ICondition right;

        public OrCondition(ICondition orLeft, ICondition orRight)
        {
            left = orLeft;
            right = orRight;
        }

        public bool Evaluate()
        {
            return (left.Evaluate() || right.Evaluate());
        }
    }
}
