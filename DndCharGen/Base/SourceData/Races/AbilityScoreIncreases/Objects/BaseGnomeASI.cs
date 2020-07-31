using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class BaseGnomeASI : AbilityScoreIncrease
    {
        public override string description => "Your Intelligence score increases by 2";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Intelligence.Score += 2;
        }
    }
}
