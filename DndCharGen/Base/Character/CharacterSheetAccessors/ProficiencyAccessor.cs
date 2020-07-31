using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;
using DndCharGen.Base.SourceData.Equipment;
using DndCharGen.Base.SourceData.Equipment.Armor;
using DndCharGen.Base.SourceData.Equipment.Weapons;
using DndCharGen.Base.SourceData.Items.Tools;

namespace DndCharGen.Base.Character.CharacterSheetAccessors
{
    public class ProficiencyAccessor<T> : CharacterSheetAccessor
    {
        T addedProficiency;

        public ProficiencyAccessor(T accessorAddedProficiency)
        {
            addedProficiency = accessorAddedProficiency;
        }

        public override void Execute()
        {
            if (typeof(T) == typeof(Tool))
            {
                User.CurrentCharacterSheet.ToolProficiencies.Add(addedProficiency as Tool);
            }
            if (typeof(T) == typeof(WeaponProficiencies))
            {
                User.CurrentCharacterSheet.WeaponProficiencies.Add((WeaponProficiencies)Enum.Parse(typeof(WeaponProficiencies), addedProficiency.ToString()));
            }
            if (typeof(T) == typeof(ArmorProficiencies))
            {
                User.CurrentCharacterSheet.ArmorProficiencies.Add((ArmorProficiencies)Enum.Parse(typeof(ArmorProficiencies), addedProficiency.ToString()));
            }
        }
    }
}
