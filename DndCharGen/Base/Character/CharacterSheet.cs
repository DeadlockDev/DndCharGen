using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.Allignment;
using DndCharGen.Base.SourceData.Classes;
using DndCharGen.Base.SourceData.Equipment;
using DndCharGen.Base.SourceData.Equipment.Armor;
using DndCharGen.Base.SourceData.Equipment.Weapons;
using DndCharGen.Base.SourceData.Items;
using DndCharGen.Base.SourceData.Items.Tools;
using DndCharGen.Base.SourceData.Races;
using DndCharGen.Base.SourceData.Spells;

namespace DndCharGen.Base.Character
{
    public class CharacterSheet
    {
        #region Basic Information
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private Background background;
        public Background Background
        {
            get { return background; }
            set { background = value; }
        }

        private string playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private string faction;
        public string Faction
        {
            get { return faction; }
            set { Faction = value; }
        }

        private Race race;
        public Race Race
        {
            get { return race; }
            set { race = value; }
        }

        private AuthorityAllignment authorityAllignment;
        private MoralityAlignment moralityAlignment;
        public string Allignment
        {
            get
            {
                return $"{authorityAllignment}{moralityAlignment}";
            }
        }

        private int experiencePoints;
        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set { experiencePoints = value; }
        }
        #endregion

        #region Class Information
        private CharacterClass characterClass;
        public CharacterClass CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; }
        }

        #region Fighter
        private int superiorityDiceCount;
        public int SuperiorityDiceCount
        {
            get { return superiorityDiceCount; }
            set { superiorityDiceCount = value; }
        }

        private Dictionary<string, string> maneuvers;
        public Dictionary<string,string> Maneuvers
        {
            get { return maneuvers; }
            set { maneuvers = value; }
        }
        #endregion

        #endregion

        #region Combat Values
        public int ArmorClass
        {
            get { return calculateArmorClass(); }
        }

        private int armorClassBonus;
        public int ArmorClassBonus
        {
            get { return armorClassBonus; }
            set { armorClassBonus = value; }
        }

        private int maxDexterityBonusInMediumArmor;
        public int MaxDexterityBonusInMediumArmor
        {
            get { return maxDexterityBonusInMediumArmor; }
            set { maxDexterityBonusInMediumArmor = value; }
        }

        private ProficientValue initiative;
        public int Initiative
        {
            get { return getProficientValueScore(initiative, Dexterity) + InitiativeBonus; }
        }

        private int initiativeBonus;
        public int InitiativeBonus
        {
            get { return initiativeBonus; }
            set { initiativeBonus = value; }
        }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int maxHP;
        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        private int hitDice;
        public string HitDice
        {
            get { return $"d{hitDice} + {Constitution.Modifier}"; }
        }
        #endregion

        #region Ability Scores
        private AbilityScore strength;
        public AbilityScore Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private AbilityScore dexterity;
        public AbilityScore Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        private AbilityScore constitution;
        public AbilityScore Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }

        private AbilityScore intelligence;
        public AbilityScore Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        private AbilityScore wisdom;
        public AbilityScore Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }

        private AbilityScore charisma;
        public AbilityScore Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }

        #endregion

        #region Bonuses
        private int inspiration;
        public int Inspiration
        {
            get { return inspiration; }
            set { inspiration = value; }
        }

        private int proficiencyBonus;
        public int ProficiencyBonus
        {
            get { return proficiencyBonus; }
            set { proficiencyBonus = value; }
        }
        #endregion

        #region Saving Throws
        private ProficientValue strengthSavingThrow;
        public ProficientValue StrengthSavingThrow
        {
            get { return strengthSavingThrow; }
        }

        public int StrengthSavingThrowScore
        {
            get { return getProficientValueScore(strengthSavingThrow, Strength); }
        }

        private ProficientValue dexteritySavingThrow;
        public ProficientValue DexteritySavingThrow
        {
            get { return strengthSavingThrow; }
        }

        public int DexteritySavingThrowScore
        {
            get { return getProficientValueScore(dexteritySavingThrow, Dexterity); }
        }

        private ProficientValue constitutionSavingThrow;
        public ProficientValue ConstitutionSavingThrow
        {
            get { return constitutionSavingThrow; }
        }

        public int ConstitutionSavingThrowScore
        {
            get { return getProficientValueScore(constitutionSavingThrow, Constitution); }
        }

        private ProficientValue intelligenceSavingThrow;
        public ProficientValue IntelligenceSavingThrow
        {
            get { return IntelligenceSavingThrow; }
        }

        public int IntelligenceSavingThrowScore
        {
            get { return getProficientValueScore(intelligenceSavingThrow, Intelligence); }
        }

        private ProficientValue wisdomSavingThrow;
        public ProficientValue WisdomSavingThrow
        {
            get { return wisdomSavingThrow; }
        }

        public int WisdomSavingThrowScore
        {
            get { return getProficientValueScore(wisdomSavingThrow, Wisdom); }
        }

        private ProficientValue charismaSavingThrow;
        public ProficientValue CharismaSavingThrow
        {
            get { return charismaSavingThrow; }
        }

        public int CharismaSavingThrowScore
        {
            get { return getProficientValueScore(charismaSavingThrow, Charisma); }
        }
        #endregion

        #region Skills
        private ProficientValue acrobatics;
        public int Acrobatics
        {
            get { return getProficientValueScore(acrobatics, Dexterity); }
        }

        private ProficientValue animalHandling;
        public int AnimalHandling
        {
            get { return getProficientValueScore(animalHandling, Wisdom); }
        }

        private ProficientValue arcana;
        public int Arcana
        {
            get { return getProficientValueScore(arcana, Intelligence); }
        }

        private ProficientValue athletics;
        public int Athletics
        {
            get { return getProficientValueScore(athletics, Strength); }
        }

        private ProficientValue deception;
        public int Deception
        {
            get { return getProficientValueScore(deception, Charisma); }
        }

        private ProficientValue history;
        public int History
        {
            get { return getProficientValueScore(history, Intelligence); }
        }

        private ProficientValue insight;
        public int Insight
        {
            get { return getProficientValueScore(insight, Wisdom); }
        }

        private ProficientValue intimidation;
        public int Intimidation
        {
            get { return getProficientValueScore(intimidation, Charisma); }
        }

        private ProficientValue investigation;
        public int Investigation
        {
            get { return getProficientValueScore(investigation, Intelligence); }
        }

        private ProficientValue medicine;
        public int Medicine
        {
            get { return getProficientValueScore(medicine, Wisdom); }
        }

        private ProficientValue nature;
        public int Nature
        {
            get { return getProficientValueScore(nature, Dexterity); }
        }

        private ProficientValue perception;
        public int Perception
        {
            get { return getProficientValueScore(perception, Wisdom); }
        }

        private ProficientValue performance;
        public int Performance
        {
            get { return getProficientValueScore(performance, Charisma); }
        }

        private ProficientValue persuasion;
        public int Persuasion
        {
            get { return getProficientValueScore(persuasion, Charisma); }
        }

        private ProficientValue religion;
        public int Religion
        {
            get { return getProficientValueScore(religion, Intelligence); }
        }

        private ProficientValue sleightOfHand;
        public int SleightOfHand
        {
            get { return getProficientValueScore(sleightOfHand, Dexterity); }
        }

        private ProficientValue stealth;
        public int Stealth
        {
            get { return getProficientValueScore(stealth, Dexterity); }
        }

        private ProficientValue survival;
        public int Survival
        {
            get { return getProficientValueScore(survival, Wisdom); }
        }

        private int passivePerceptionBonus;
        public int PassivePerceptionBonus
        {
            get { return passivePerceptionBonus; }
            set { passivePerceptionBonus = value; }
        }

        public int PassivePerception
        {
            get { return 10 + Wisdom.Modifier + passivePerceptionBonus; }
        }

        private int passiveInvestigationBonus;
        public int PassiveInvestigationBonus
        {
            get { return passiveInvestigationBonus; }
            set { passiveInvestigationBonus = value; }
        }

        public int PassiveInvestigation
        {
            get
            {
                return 10 + Intelligence.Modifier + passivePerceptionBonus;
            }
        }
        #endregion

        #region Free Form Information
        private string personalityTraits;
        public string PersonalityTraits
        {
            get { return personalityTraits; }
            set { personalityTraits = value; }
        }

        private string ideals;
        public string Ideals
        {
            get { return ideals; }
            set { ideals = value; }
        }

        private string bonds;
        public string Bonds
        {
            get { return bonds; }
            set { bonds = value; }
        }

        private string flaws;
        public string Flaws
        {
            get { return flaws; }
            set { flaws = value; }
        }
        #endregion

        #region Spells, Equipment, Feats and Inventory
        private Dictionary<string, string> spells;
        public Dictionary<string, string> Spells
        {
            get { return spells; }
        }

        private List<Armor> armor;
        public List<Armor> Armor
        {
            get { return armor; }
        }

        private List<Weapon> weapons;
        public List<Weapon> Weapons
        {
            get { return weapons; }
        }

        private Dictionary<string, string> inventory;
        public Dictionary<string, string> Inventory
        {
            get { return inventory; }
        }

        private Dictionary<string, string> feats;
        private Dictionary<string, string> Feats
        {
            get { return feats; }
        }
        #endregion

        #region Proficiencies
        private List<Tool> toolProficiencies;
        public List<Tool> ToolProficiencies
        {
            get
            {
                return toolProficiencies;
            }
        }

        private List<WeaponProficiencies> weaponProficiencies;
        public List<WeaponProficiencies> WeaponProficiencies
        {
            get
            {
                return weaponProficiencies;
            }
        }

        private List<ArmorProficiencies> armorProficiencies;
        public List<ArmorProficiencies> ArmorProficiencies
        {
            get
            {
                return armorProficiencies;
            }
        }
        #endregion

        private int calculateArmorClass()
        {
            int runningTotal = 0;
            if (Armor.Count > 0)
            {
                foreach (Armor equipment in Armor)
                {
                    runningTotal += equipment.CalculateArmorClass();
                }
            }
            else
            {
                runningTotal = 10 + Dexterity.Modifier;
            }
            return runningTotal + armorClassBonus;
        }

        private int getProficientValueScore(ProficientValue proficientValue, AbilityScore backingScore)
        {
            if (proficientValue.IsProficient)
            {
                return proficientValue.Score + backingScore.Modifier;
            }
            else
            {
                return proficientValue.Score;
            }
        }
    }
}
