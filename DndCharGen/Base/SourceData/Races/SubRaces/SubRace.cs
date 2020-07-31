using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using DndCharGen.Base.SourceData.CharacterSheetAreas;
using DndCharGen.Base.SourceData.Equipment;
using DndCharGen.Base.SourceData.Equipment.Armor;
using DndCharGen.Base.SourceData.Equipment.Weapons;
using DndCharGen.Base.SourceData.Items.Tools;
using DndCharGen.Base.SourceData.Languages;
using DndCharGen.Base.SourceData.Races.AbilityScoreIncreases;
using DndCharGen.Base.SourceData.Races.RaceTraits;
using DndCharGen.Base.SourceData.Races.Sizes;
using DndCharGen.Workflow.PromptedTasks;

namespace DndCharGen.Base.SourceData.Races
{
    public class SubRace
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private int speed;
        public int Speed
        {
            get { return speed; }
        }

        private Size size;
        public Size Size
        {
            get { return size; }
        }

        private List<AbilityScoreIncrease> abilityScoreIncreases;
        public List<AbilityScoreIncrease> AbilityScoreIncreases
        {
            get { return abilityScoreIncreases; }
        }

        private List<Tool> toolProficiences;
        public List<Tool> ToolProficiencies
        {
            get { return toolProficiences; }
        }

        private List<Skills> skillProficiencies;
        public List<Skills> SkillsProficiencies
        {
            get { return skillProficiencies; }
        }

        private List<WeaponProficiencies> weaponProficiences;
        public List<WeaponProficiencies> WeaponProficiencies
        {
            get { return weaponProficiences; }
        }

        private List<ArmorProficiencies> armorProficiences;
        public List<ArmorProficiencies> ArmorProficiencies
        {
            get { return armorProficiences; }
        }

        private List<Language> languages;
        public List<Language> Languages
        {
            get { return languages; }
        }

        private List<Trait> traits;
        public List<Trait> Traits
        {
            get { return traits; }
        }

        private List<IPromptedTask> promptedTasks;
        public List<IPromptedTask> PromptedTasks
        {
            get { return promptedTasks; }
        }

        public SubRace(string subRaceName, 
            int subRaceSpeed, 
            Size subRaceSize,
            List<AbilityScoreIncrease> subRaceAbilityScoreIncrease,
            List<Tool> subRaceToolProficiencies,
            List<Skills> subRaceSkillsProficiencies,
            List<WeaponProficiencies> subRaceWeaponProficiences,
            List<ArmorProficiencies> subRaceArmorProficiencies,
            List<Language> subRaceLanguages,
            List<Trait> subRaceTraits,
            List<IPromptedTask> subRacePromptedTasks = null)
        {
            name = subRaceName;
            speed = subRaceSpeed;
            size = subRaceSize;
            abilityScoreIncreases = subRaceAbilityScoreIncrease;
            toolProficiences = subRaceToolProficiencies;
            skillProficiencies = subRaceSkillsProficiencies;
            weaponProficiences = subRaceWeaponProficiences;
            armorProficiences = subRaceArmorProficiencies;
            languages = subRaceLanguages;
            traits = subRaceTraits;
            promptedTasks = subRacePromptedTasks ?? new List<IPromptedTask>();
        }
    }
}
