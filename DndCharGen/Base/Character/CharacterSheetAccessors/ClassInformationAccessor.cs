using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;

namespace DndCharGen.Base.Character.CharacterSheetAccessors
{
    public class ClassInformationAccessor<T> : CharacterSheetAccessor
    {
        private T data;
        ClassInformation classInformation;

        public ClassInformationAccessor(ClassInformation accessorClassInformation, T accessorData)
        {
            data = accessorData;
            classInformation = accessorClassInformation;
        }

        public override void Execute()
        {
            switch (classInformation)
            {
                case ClassInformation.SuperiorityDice:
                    int amountToAdd = Convert.ToInt32(data);
                    User.CurrentCharacterSheet.SuperiorityDiceCount += amountToAdd;
                    break;
                case ClassInformation.Maneuvers:
                    break;
                default:
                    break;
            }
        }
    }
}
