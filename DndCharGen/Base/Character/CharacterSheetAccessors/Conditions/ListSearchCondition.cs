using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DndCharGen.Base.Character.CharacterSheetAccessors.Conditions
{
    public class ListSearchCondition<T> : ICondition
    {
        private T searchedObject;
        private List<T> targetList;

        public ListSearchCondition(T conditionSearchedObject, List<T> conditionTargetList)
        {
            searchedObject = conditionSearchedObject;
            targetList = conditionTargetList;
        }

        public bool Evaluate()
        {
            return (targetList.Contains(searchedObject));
        }
    }
}
