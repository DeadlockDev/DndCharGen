using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.Character.CharacterSheetAccessors.Conditions
{
    public class GenericCondition<T> : ICondition
    {
        private T leftSide;
        private T rightSide;
        private Operator conditionOperator;

        public GenericCondition(T left, Operator middle, T right) 
        {
            leftSide = left;
            conditionOperator = middle;
            rightSide = right;
        }

        public bool Evaluate()
        {
            int intLeft;
            int intRight;
            switch (conditionOperator)
            {
                case Operator.Equals:
                    return (leftSide.Equals(rightSide));
                case Operator.DoesNotEqual:
                    return (leftSide.Equals(rightSide));
                case Operator.GreaterThanInclusive:
                    intLeft = Convert.ToInt32(leftSide);
                    intRight = Convert.ToInt32(rightSide);
                    return (intLeft >= intRight);
                case Operator.GreaterThanExclusive:
                    intLeft = Convert.ToInt32(leftSide);
                    intRight = Convert.ToInt32(rightSide);
                    return (intLeft > intRight);
                case Operator.LessThanInclusive:
                    intLeft = Convert.ToInt32(leftSide);
                    intRight = Convert.ToInt32(rightSide);
                    return (intLeft <= intRight);
                case Operator.LessThanExclusive:
                    intLeft = Convert.ToInt32(leftSide);
                    intRight = Convert.ToInt32(rightSide);
                    return (intLeft < intRight);
                default:
                    throw new Exception();
            }
        }
    }
}
