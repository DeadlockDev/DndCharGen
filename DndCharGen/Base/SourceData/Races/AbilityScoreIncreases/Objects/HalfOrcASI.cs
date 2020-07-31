using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class HalfOrcASI : AbilityScoreIncrease
    {
        public override string description => "Your Strength score increases by 2, and your Constitution score increases by 1";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Constitution.Score += 2;
            User.CurrentCharacterSheet.Constitution.Score += 1;
        }
    }
}
