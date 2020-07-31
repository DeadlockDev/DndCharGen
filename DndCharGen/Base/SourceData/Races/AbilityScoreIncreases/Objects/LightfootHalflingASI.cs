using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases
{
    public class LightfootHalflingASI : AbilityScoreIncrease
    {
        public override string description => "Your Charisma score increases by 1";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Charisma.Score += 1;
        }
    }
}
