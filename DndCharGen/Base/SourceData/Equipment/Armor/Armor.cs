using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.SourceData.Equipment.Armor
{
    public abstract class Armor : Equipment
    {
        public int StrengthRequirement;
        public bool HasStealthDisadvantage;

        public abstract int CalculateArmorClass();
    }
}
