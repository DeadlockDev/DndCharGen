using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class BaseDwarfASI : AbilityScoreIncrease
    {
        public override string description => "Your Constitution score increases by 2";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Constitution.Score += 2;
        }
    }
}
