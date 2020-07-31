using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.CharacterSheetAreas;
using DndCharGen.Base.SourceData.Equipment;
using DndCharGen.Base.SourceData.Equipment.Armor;
using DndCharGen.Base.SourceData.Equipment.Weapons;
using DndCharGen.Base.SourceData.Items.Tools;
using DndCharGen.Base.SourceData.Items.Tools.Objects;
using DndCharGen.Base.SourceData.Languages;
using DndCharGen.Base.SourceData.Races.AbilityScoreIncreases;
using DndCharGen.Base.SourceData.Races.AbilityScoreIncreases.Objects;
using DndCharGen.Base.SourceData.Races.RaceTraits;
using DndCharGen.Base.SourceData.Races.RaceTraits.Objects;
using DndCharGen.Base.SourceData.Races.Sizes;
using DndCharGen.Workflow.PromptedTasks;
using DndCharGen.Workflow.PromptedTasks.Tasks;

namespace DndCharGen.Base.SourceData.Races.SubRaces.Objects
{
    public static class SubRaceObjects
    {
        #region Dwarf
        public static SubRace HillDwarf = new SubRace("Hill Dwarf", 25, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseDwarfASI(), new HillDwarfASI()
                },
            new List<Tool>()
                { ToolObjects.SmithsTools, ToolObjects.BrewersSupplies, ToolObjects.MasonsTools },
            new List<Skills>(),
            new List<WeaponProficiencies>()
                { WeaponProficiencies.Battleaxe, WeaponProficiencies.LightHammer, WeaponProficiencies.Warhammer },
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Dwarvish },
            new List<Trait>()
                { TraitObjects.DwarfDarkVision, TraitObjects.DwarvenResilience, TraitObjects.StoneCunning, TraitObjects.DwarvenToughness });

        public static SubRace MountainDwarf = new SubRace("Mountain Dwarf", 25, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseDwarfASI(), new MountainDwarfASI()
                },
            new List<Tool>()
                { ToolObjects.SmithsTools, ToolObjects.BrewersSupplies, ToolObjects.MasonsTools },
            new List<Skills>(),
            new List<WeaponProficiencies>()
                { WeaponProficiencies.Battleaxe, WeaponProficiencies.LightHammer, WeaponProficiencies.Warhammer },
            new List<ArmorProficiencies>() 
                { ArmorProficiencies.Light, ArmorProficiencies.Medium },
            new List<Language>()
                { Language.Common, Language.Dwarvish },
            new List<Trait>()
                { TraitObjects.DwarfDarkVision, TraitObjects.DwarvenResilience, TraitObjects.StoneCunning });
        #endregion

        #region Elf
        public static SubRace HighElf = new SubRace("High Elf", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseElfASI(), new HighElfASI()
                },
            new List<Tool>(),
            new List<Skills>()
                { Skills.Perception },
            new List<WeaponProficiencies>()
                { WeaponProficiencies.Longsword, WeaponProficiencies.Shortsword, WeaponProficiencies.Shortbow, WeaponProficiencies.Longbow },
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Elvish },
            new List<Trait>()
                { TraitObjects.ElfDarkVision, TraitObjects.ElfFeyAncestry, TraitObjects.Trance },
            new List<IPromptedTask>()
                { new CantripSelector(), new LanguageSelector() }
            );

        public static SubRace WoodElf = new SubRace("Wood Elf", 35, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseElfASI(), new WoodElfASI()
                },
            new List<Tool>(),
            new List<Skills>()
                { Skills.Perception },
            new List<WeaponProficiencies>()
                { WeaponProficiencies.Longsword, WeaponProficiencies.Shortsword, WeaponProficiencies.Shortbow, WeaponProficiencies.Longbow },
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Elvish },
            new List<Trait>()
                { TraitObjects.ElfDarkVision, TraitObjects.ElfFeyAncestry, TraitObjects.Trance, TraitObjects.MaskOfTheWild });

        public static SubRace DarkElf = new SubRace("Dark Elf (Drow)", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseElfASI(), new DarkElfASI()
                },
            new List<Tool>(),
            new List<Skills>()
                { Skills.Perception },
            new List<WeaponProficiencies>()
                { WeaponProficiencies.Longsword, WeaponProficiencies.Shortsword, WeaponProficiencies.Shortbow, WeaponProficiencies.Longbow,
                  WeaponProficiencies.Rapier, WeaponProficiencies.CrosswbowHand},
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Elvish },
            new List<Trait>()
                { TraitObjects.ElfDarkVision, TraitObjects.ElfFeyAncestry, TraitObjects.Trance, TraitObjects.DrowMagic });
        #endregion

        #region Halfling
        public static SubRace LightfootHalfing = new SubRace("Lightfoot Halfing", 25, Size.S,
            new List<AbilityScoreIncrease>()
                {
                    new BaseHalflingASI(), new LightfootHalflingASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Halfling },
            new List<Trait>()
                { TraitObjects.Lucky, TraitObjects.Brave, TraitObjects.HalflingNimbleness, TraitObjects.NaturallyStealthy }
            );

        public static SubRace StoutHalfing = new SubRace("Stout Halfing", 25, Size.S,
            new List<AbilityScoreIncrease>()
                {
                    new BaseHalflingASI(), new LightfootHalflingASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Halfling },
            new List<Trait>()
                { TraitObjects.Lucky, TraitObjects.Brave, TraitObjects.HalflingNimbleness, TraitObjects.StoutResilience }
            );
        #endregion

        #region Human
        public static SubRace BaseHuman = new SubRace("Human", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new HumanASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common},
            new List<Trait>()
            );

        public static SubRace VariantHuman = new SubRace("Variant Human", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new VariantHumanASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common},
            new List<Trait>(),
            new List<IPromptedTask>() { new SkillSelector(), new FeatSelector()}
            );
        #endregion

        #region Dragonborn
        public static SubRace Dragonborn = new SubRace("Dragoborn", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new BaseDragonbornASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common},
            new List<Trait>() 
                { TraitObjects.BreathWeapon, TraitObjects.DamageResistence },
            new List<IPromptedTask> 
                { new DraconicAncestrySelector() }
            );
        #endregion

        #region Gnome
        public static SubRace ForestGnome = new SubRace("Forest Gnome", 25, Size.S,
            new List<AbilityScoreIncrease>()
                {
                    new BaseGnomeASI(), new ForestGnomeASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Gnomish},
            new List<Trait>() 
                { TraitObjects.GnomeDarkvision, TraitObjects.GnomeCunning, TraitObjects.SpeakWithSmallBeasts}
            );

        public static SubRace RockGnome = new SubRace("Rock Gnome", 25, Size.S,
            new List<AbilityScoreIncrease>()
                {
                    new BaseGnomeASI(), new RockGnomeASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Gnomish},
            new List<Trait>()
                { TraitObjects.GnomeDarkvision, TraitObjects.GnomeCunning, TraitObjects.ArtificersLore, TraitObjects.Tinker}
            );
        #endregion

        #region Half-Elf
        public static SubRace HalfElf = new SubRace("Half-Elf", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new HalfElfASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Elvish},
            new List<Trait>()
                { TraitObjects.HalfElfDarkvision, TraitObjects.ElfFeyAncestry},
            new List<IPromptedTask>() { new LanguageSelector(), new SkillSelector() }
            );
        #endregion

        #region Half-Orc
        public static SubRace HalfOrc = new SubRace("Half-Orc", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new HalfOrcASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common, Language.Orc},
            new List<Trait>()
                { TraitObjects.HalfOrcDarkvision, TraitObjects.Menacing, TraitObjects.RelentlessEndurance, TraitObjects.SavageAttacks}
            );
        #endregion

        #region Tiefling
        public static SubRace Tiefling = new SubRace("Tielfing", 30, Size.M,
            new List<AbilityScoreIncrease>()
                {
                    new TieflingASI()
                },
            new List<Tool>(),
            new List<Skills>(),
            new List<WeaponProficiencies>(),
            new List<ArmorProficiencies>(),
            new List<Language>()
                { Language.Common},
            new List<Trait>()
                { TraitObjects.TieflingDarkvision, TraitObjects.HellishResistance, TraitObjects.InfernalLegacy}
            );
        #endregion
    }
}
