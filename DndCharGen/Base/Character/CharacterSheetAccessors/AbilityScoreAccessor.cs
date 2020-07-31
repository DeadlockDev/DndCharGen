using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;

namespace DndCharGen.Base.Character.CharacterSheetAccessors
{
    public class AbilityScoreAccessor : CharacterSheetAccessor
    {
        private AbilityScores ability;
        private int increaseDecreaseValue;
        private bool gainProficiency;

        public AbilityScoreAccessor(AbilityScores accessorAbility, int accessorIncreaseDecreaseValue, bool accessorGainSacvingThrowProficiency = false)
        {
            ability = accessorAbility;
            increaseDecreaseValue = accessorIncreaseDecreaseValue;
            gainProficiency = accessorGainSacvingThrowProficiency;
        }

        public override void Execute()
        {
            switch (ability)
            {
                case AbilityScores.Strength:
                    User.CurrentCharacterSheet.Strength.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.StrengthSavingThrow.IsProficient = true; }
                    break;
                case AbilityScores.Dexterity:
                    User.CurrentCharacterSheet.Dexterity.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.DexteritySavingThrow.IsProficient = true; }
                    break;
                case AbilityScores.Constitution:
                    User.CurrentCharacterSheet.Constitution.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.ConstitutionSavingThrow.IsProficient = true; }
                    break;
                case AbilityScores.Intelligence:
                    User.CurrentCharacterSheet.Intelligence.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.IntelligenceSavingThrow.IsProficient = true; }
                    break;
                case AbilityScores.Wisdom:
                    User.CurrentCharacterSheet.Wisdom.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.WisdomSavingThrow.IsProficient = true; }
                    break;
                case AbilityScores.Charisma:
                    User.CurrentCharacterSheet.Charisma.Score += increaseDecreaseValue;
                    if (gainProficiency) { User.CurrentCharacterSheet.CharismaSavingThrow.IsProficient = true; }
                    break;
                default:
                    break;
            }
        }
    }
}
