using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class HillDwarfASI : AbilityScoreIncrease
    {
        public override string description => "Your Wisdom score increases by 1";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Wisdom.Score += 1;
        }
    }
}
