using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DndCharGen.Base.Character;

namespace DndCharGen.Workflow.PromptedTasks
{
    public interface IPromptedTask
    {
        Dictionary<string, object> Parameters { get; }
        void Execute();
    }
}
