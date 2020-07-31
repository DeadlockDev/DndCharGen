using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character;

namespace DndCharGen.Base.SourceData.Races.AbilityScoreIncreases
{
    public abstract class AbilityScoreIncrease
    {
        public abstract string description { get; }

        public abstract void PerformIncrease();
    }
}
