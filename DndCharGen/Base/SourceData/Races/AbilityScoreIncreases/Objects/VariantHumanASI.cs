using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;
using DndCharGen.Workflow.PromptedTasks.Tasks;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects
{
    public class VariantHumanASI : AbilityScoreIncrease
    {
        public override string description => "Two different ability scores of your choice increase by 1.";

        public override void PerformIncrease()
        {
            new AbilitySelector().Execute();
        }
    }
}
