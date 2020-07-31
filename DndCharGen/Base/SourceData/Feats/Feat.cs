using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;
using DndCharGen.Base.Character.CharacterSheetAccessors;
using DndCharGen.Base.Character.CharacterSheetAccessors.Conditions;
using DndCharGen.Workflow.PromptedTasks;

namespace DndCharGen.Base.SourceData
{
    public class Feat
    {
        private string featlName;
        public string FeatName { get { return featlName; } }

        private string featDescription;
        public string FeatDescription { get { return FeatDescription; } }

        private CharacterSheetCondition prerequisite;
        private List<CharacterSheetAccessor> accessors;
        private List<IPromptedTask> promptedTasks;

        public Feat(string name, string description, CharacterSheetCondition featPrerequisite = null, 
            List<CharacterSheetAccessor> featAccessors = null, List<IPromptedTask> featPromptedTasks = null)
        {
            featlName = name;
            featDescription = description;
            prerequisite = featPrerequisite;
            accessors = featAccessors ?? new List<CharacterSheetAccessor>();
            promptedTasks = featPromptedTasks ?? new List<IPromptedTask>();
        }

        public void ApplyFeatAccessors(CharacterSheet characterSheet)
        {
            foreach(CharacterSheetAccessor accessor in accessors)
            {
                accessor.Execute();
            }

            foreach (IPromptedTask task in promptedTasks)
            {
                task.Execute();
            }
        }

        public bool EvaluatePrerequisite()
        {
            return prerequisite?.Evaluate() ?? true;
        }
    }
}
