using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character.CharacterSheetAccessors;
using DndCharGen.Base.Character.CharacterSheetAccessors.Conditions;
using DndCharGen.Base.SourceData.CharacterSheetAreas;
using DndCharGen.Base.SourceData.Equipment.Armor;
using DndCharGen.Base.SourceData.Equipment.Weapons;
using DndCharGen.Base.SourceData.Spells;
using DndCharGen.Workflow.PromptedTasks;
using DndCharGen.Workflow.PromptedTasks.Tasks;

namespace DndCharGen.Base.SourceData.Feats.Objects
{
    public static class FeatObjects
    {
        public static Feat Actor = new Feat(
            "Actor",
            "+1 in Cha., advantage on Deception and Performance checks, mimic the speech of a person or the sounds made by a creature.",
            featAccessors: new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Charisma, 1) });

        public static Feat Alert = new Feat(
            "Alert",
            "+5 to initiative, you can't be surprised, and creatures you don't see don't gain advantage on attack roll against you.",
            featAccessors: new List<CharacterSheetAccessor>() { new CombatValueAccessor(CombatValues.Initiative, 5) }
            );

        public static Feat Athlete = new Feat(
            "Athlete",
            "+1 in Str. or Dex., you stand up and climb more quickly, and you can jump with only a 5-ft run.",
            featPromptedTasks : new List<IPromptedTask>() { new AbilitySelector() }
            );

        public static Feat Charger = new Feat(
            "Charger",
            "As part of the Dash action you can make a melee attack with a +5 bonus if you move at least 10 ft before."
            );

        public static Feat CrossbowExpert = new Feat(
            "Crossbow Expert",
            "You ignore the loading property of crossbows and don't have disadvantage for being in contact with a creature when you shoot."
            );

        public static Feat DefensiveDuelist = new Feat(
            "Defensive Duelist",
            "You can add you proficiency bonus to your AC if you are wielding a finesse weapon.",
            featPrerequisite : new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Dexterity.Score, Operator.GreaterThanInclusive, 13))
            );

        public static Feat DualWielder = new Feat(
            "Dual Wielder",
            "+1 to AC if you're wielding a melee weapon in each hand, two-weapon fighting with non-light weapon, draw two weapons."
            );

        public static Feat DungeonDelver = new Feat(
            "Dungeon Delver",
            "Advantage to Perception and Investigation checks, to saving throws vs traps, and search for traps at normal pace."
            );

        public static Feat Durable = new Feat(
            "Durable",
            "+1 in Con. and for each Hit Dice you regain a minimum of hit points equals to 2 x your Constitution modifier.",
            featAccessors : new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Constitution, 1)}
            );

        public static Feat ElementalAdept = new Feat(
            "Elemental Adept",
            "Your spells ignore resistance to a damage type (acid, cold, fire, lightning, or thunder) and treat any 1 in damage as a 2.",
            featPrerequisite : new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Spells.Count, Operator.GreaterThanInclusive, 1))
            );

        public static Feat Grappler = new Feat(
            "Grappler",
            "You have advantage on attack rolls when grappling, and can try to restrain a creature grappled by you.",
            featPrerequisite : new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Strength.Score, Operator.GreaterThanInclusive, 13))
            );

        public static Feat Healer = new Feat(
            "Healer",
            "You can stabilize a creature and restore it to 1 hp, or restore [1d6+4+its number of Hit Dice] hp to it."
            );

        public static Feat HeavilyArmored = new Feat(
            "Heavily Armored",
            "+1 in Str. and you gain proficiency with heavy armor.",
            featPrerequisite : new CharacterSheetCondition(new ListSearchCondition<ArmorProficiencies>(ArmorProficiencies.Medium, User.CurrentCharacterSheet.ArmorProficiencies)),
            featAccessors : new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Strength, 1), new ProficiencyAccessor<ArmorProficiencies>(ArmorProficiencies.Heavy)}
            );

        public static Feat HeavyArmorMaster = new Feat(
            "Heavy Armor Master",
            "+1 in Str. and bludgeoning, piercing, and slashing damage are reduced by 3 if you are wearing an heavy armor.",
            featPrerequisite: new CharacterSheetCondition(new ListSearchCondition<ArmorProficiencies>(ArmorProficiencies.Heavy, User.CurrentCharacterSheet.ArmorProficiencies)),
            featAccessors: new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Strength, 1)}
            );

        public static Feat InspiringLeader = new Feat(
            "Inspiring Leader",
            "Up to 6 creatures within 30 ft of you can gain temporary hp equal to your levei + your Cha. modifier.",
            featPrerequisite: new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Charisma.Score, Operator.GreaterThanInclusive, 13))
            );

        public static Feat KeenMind = new Feat(
            "Keen Mind",
            "+1 in Int., you know which way is north, when is the next sunrise/sunset, and recall any events within the past month.",
            featAccessors : new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Intelligence, 1) }
            );

        public static Feat LightlyArmored = new Feat(
            "LightlyArmored",
            "+1 in Str. or Dex. and you gain proficiency with light armor.",
            featAccessors: new List<CharacterSheetAccessor>() { new ProficiencyAccessor<ArmorProficiencies>(ArmorProficiencies.Light) },
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector() }
            );

        public static Feat Linguist = new Feat(
            "Linguist",
            "+1 in Int., you learn three languages, and you can ably create ciphers.",
            featAccessors: new List<CharacterSheetAccessor>() { new AbilityScoreAccessor(AbilityScores.Intelligence, 1) },
            featPromptedTasks: new List<IPromptedTask>() { new LanguageSelector() }
            );

        public static Feat Lucky = new Feat(
            "Lucky",
            "You can reroll one d20 or force to reroll an attack roll against you (3/long rest)."
            );

        public static Feat MageSlayer = new Feat(
            "Mage Slayer",
            "You can use a reaction to make a melee attack against a spellcaster and advantage on saving throws against spell within 5 ft."
            );

        public static Feat MagicInitiate = new Feat(
            "Magic Initiate",
            "You learn two cantrips and one 1st-level spell from one class.",
            featPromptedTasks: new List<IPromptedTask>() { new CantripSelector(), new SpellSelector() }
            );

        public static Feat MartialAdept = new Feat(
            "Martial Adept",
            "You learn two maneuvers from Battle Master archetype and gain one superiority die (d6).",
            featAccessors : new List<CharacterSheetAccessor>() { new ClassInformationAccessor<int>(ClassInformation.SuperiorityDice, 1)},
            featPromptedTasks : new List<IPromptedTask>() { new ManeuverSelector() }
            );

        public static Feat MediumArmorMaster = new Feat(
            "Medium Armor Master",
            "No disadvantage to Stealth checks wearing medium armor and Dexterity bonus max to +3 instead of +2.",
            featPrerequisite : new CharacterSheetCondition(new ListSearchCondition<ArmorProficiencies>(ArmorProficiencies.Medium, User.CurrentCharacterSheet.ArmorProficiencies))
            );

        public static Feat Mobile = new Feat(
            "Mobile",
            "Your speed increase by 10 ft, you can Dash on difficult terrain without malus, and don't provoke opportunity attacks in melee.",
            featAccessors: new List<CharacterSheetAccessor>() { new CombatValueAccessor(CombatValues.Speed, 10)}
            );

        public static Feat ModeratelyArmored = new Feat(
            "Moderately Armored",
            "+1 in Str. or Dex. and you gain proficiency with medium armor and shields.",
            featPrerequisite: new CharacterSheetCondition(new ListSearchCondition<ArmorProficiencies>(ArmorProficiencies.Light, User.CurrentCharacterSheet.ArmorProficiencies)),
            featAccessors: new List<CharacterSheetAccessor>() { new ProficiencyAccessor<ArmorProficiencies>(ArmorProficiencies.Medium), new ProficiencyAccessor<ArmorProficiencies>(ArmorProficiencies.Shield) },
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector() }
            );

        public static Feat MountedCombatant = new Feat(
            "Mounted Combatant",
            "Advantage on melee attacks against unmounted creature and force an attack to target you instead of your mount."
            );

        public static Feat Observant = new Feat(
            "Observant",
            "+1 in Int. or Wis., you can read on lips, and you have a +5 bonus in passive Perception and passive Investigation.",
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector() }
            );

        public static Feat PolearmMaster = new Feat(
            "Polearm Master",
            "You can make an extra attack with a polearm weapon, and make an opportunity attack if a creature enter your reach."
            );

        public static Feat Resilient = new Feat(
            "Resilient",
            "+1 in one ability and you gain proficiency in saving throws using this ability.",
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector() }
            );

        public static Feat RitualCaster = new Feat(
            "Ritual Caster",
            "You have a ritual book with two 1-st level ritual spells from one class and you can later on add other ritual spells you found.",
            featPromptedTasks: new List<IPromptedTask>() { new SpellSelector() },
            featPrerequisite: new CharacterSheetCondition(new OrCondition(
                new GenericCondition<int>(User.CurrentCharacterSheet.Intelligence.Score, Operator.GreaterThanInclusive, 13),
                new GenericCondition<int>(User.CurrentCharacterSheet.Wisdom.Score, Operator.GreaterThanInclusive, 13)))
            );

        public static Feat SavageAttacker = new Feat(
            "Savage Attacker",
            "You can reroll melee weapon attack damage once per turn."
            );

        public static Feat Sentinel = new Feat(
            "Sentinel",
            "A successful OA reduce creature's speed to 0 for this turn and possibility to make an OA even if the enemy take Disengage."
            );

        public static Feat Sharpshooter = new Feat(
            "Sharpshooter",
            "Your ranged attacks ignore some cover, no disavantage at long range, and possibility to take -5 to hit for +10 on ranged damage."
            );

        public static Feat ShieldMaster = new Feat(
            "Shield Master",
            "Attack also allows to shove, shield bonus to Dex. saving throws againts spells, and no 1/2 damage on successful saving throw."
            );

        public static Feat Skilled = new Feat(
            "Skilled",
            "You gain proficiency with three skills or tools.",
            featPromptedTasks: new List<IPromptedTask>() { new SkilledFeatProficiencySelector() }
            );

        public static Feat Skulker = new Feat(
            "Skulker",
            "Ranged weapon attack doesn't reveal your position and possibility to hide in a lighlly obscured area.",
            new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Dexterity.Score, Operator.GreaterThanInclusive, 13))
            );

        public static Feat SpellSniper = new Feat(
            "Skulker",
            "Offensive spell's range doubled, these spells ignore some cover, and you learn one offensive cantrip.",
            new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Spells.Count, Operator.GreaterThanInclusive, 1))
            );

        public static Feat TavernBrawler = new Feat(
            "Tavern Brawler",
            "+1 in Str. or Con., proficiency with improvised weapons, d4 for unarmed strike, and grapple with a bonus action.",
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector() },
            featAccessors: new List<CharacterSheetAccessor>() { new ProficiencyAccessor<WeaponProficiencies>(WeaponProficiencies.ImprovisedWeapons) }
            );

        public static Feat Tough = new Feat(
            "Tough",
            "Your hit point maximum increases by an amount equal to twice your level then by +2 at each level.",
            featAccessors: new List<CharacterSheetAccessor>() { new CombatValueAccessor(CombatValues.MaxHP, User.CurrentCharacterSheet.Level * 2)}
            );

        public static Feat WarCaster = new Feat(
            "War Caster",
            "You have advantage on saving throws to maintain concentration and you can cast some spells as part of an OA with a reaction.",
            new CharacterSheetCondition(new GenericCondition<int>(User.CurrentCharacterSheet.Spells.Count, Operator.GreaterThanInclusive, 1))
            );

        public static Feat WeaponMaster = new Feat(
            "Weapon Master",
            "+1 in Str. or Dex. and you gain proficiency with four weapons.",
            featPromptedTasks: new List<IPromptedTask>() { new AbilitySelector(), new WeaponProficiencySelector() }
            );
    }
}
