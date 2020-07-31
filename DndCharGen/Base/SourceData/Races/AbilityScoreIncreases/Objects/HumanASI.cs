using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class HumanASI : AbilityScoreIncrease
    {
        public override string description => "Your Ability Scores each increase by 1.";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Strength.Score += 1;
            User.CurrentCharacterSheet.Dexterity.Score += 1;
            User.CurrentCharacterSheet.Constitution.Score += 1;
            User.CurrentCharacterSheet.Charisma.Score += 1;
            User.CurrentCharacterSheet.Wisdom.Score += 1;
            User.CurrentCharacterSheet.Constitution.Score += 1;
        }
    }
}
