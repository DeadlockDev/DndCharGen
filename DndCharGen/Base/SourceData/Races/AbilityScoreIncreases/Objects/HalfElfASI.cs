using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;
using DndCharGen.Workflow.PromptedTasks.Tasks;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class HalfElfASI : AbilityScoreIncrease
    {
        public override string description => "Your Charisma score increases by 2, and two other ability scores increase by 1";

        public override void PerformIncrease()
        {
            User.CurrentCharacterSheet.Constitution.Score += 2;
            new AbilitySelector().Execute();
        }
    }
}
