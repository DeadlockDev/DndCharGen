using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;

namespace DndCharGen.Base.Character.CharacterSheetAccessors
{
    public class CombatValueAccessor : CharacterSheetAccessor
    {
        private CombatValues combatValue;
        private int increaseDecrease;

        public CombatValueAccessor(CombatValues accessorCombatValue, int accessorIncreaseDecrease)
        {
            combatValue = accessorCombatValue;
            increaseDecrease = accessorIncreaseDecrease;
        }

        public override void Execute()
        {
            switch (combatValue)
            {
                case CombatValues.ArmorClass:
                    User.CurrentCharacterSheet.ArmorClassBonus += increaseDecrease; 
                    break;
                case CombatValues.Initiative:
                    User.CurrentCharacterSheet.InitiativeBonus += increaseDecrease;
                    break;
                case CombatValues.Speed:
                    User.CurrentCharacterSheet.Speed += increaseDecrease;
                    break;
                case CombatValues.MaxHP:
                    User.CurrentCharacterSheet.MaxHP += increaseDecrease;
                    break;
                case CombatValues.MaxDexBonusMed:
                    User.CurrentCharacterSheet.MaxDexterityBonusInMediumArmor += increaseDecrease;
                    break;
                default:
                    break;
            }
        }
    }
}
