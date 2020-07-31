using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.Character.CharacterSheetAccessors;

namespace DndCharGen.Base.SourceData.Races.RaceTraits.Objects
{
    public static class TraitObjects
    {
        public static List<KeyValuePair<string, string>> sourceDataParsed = parseSourceData();

        #region Dwarf Traits
        public static Trait DwarfDarkVision = new Trait(sourceDataParsed[0]);
        public static Trait DwarvenResilience = new Trait(sourceDataParsed[1]);
        public static Trait DwarvenCombatTraining = new Trait(sourceDataParsed[2]);
        public static Trait StoneCunning = new Trait(sourceDataParsed[3]);
        public static Trait DwarvenToughness = new Trait(sourceDataParsed[4]);
        #endregion
        #region Elf
        public static Trait ElfDarkVision = new Trait(sourceDataParsed[5]);
        public static Trait ElfFeyAncestry = new Trait(sourceDataParsed[6]);
        public static Trait Trance = new Trait(sourceDataParsed[7]);
        public static Trait FleetOfFoot = new Trait(sourceDataParsed[8]);
        public static Trait MaskOfTheWild = new Trait(sourceDataParsed[9]);
        public static Trait SuperiorDarkvision = new Trait(sourceDataParsed[10]);
        public static Trait SunlightSensitivity = new Trait(sourceDataParsed[11]);
        //TODO add spells to DrowMagic
        public static Trait DrowMagic = new Trait(sourceDataParsed[12], new SpellListAccessor());
        #endregion
        #region Halfling
        public static Trait Lucky = new Trait(sourceDataParsed[13]);
        public static Trait Brave = new Trait(sourceDataParsed[14]);
        public static Trait HalflingNimbleness = new Trait(sourceDataParsed[15]);
        public static Trait NaturallyStealthy = new Trait(sourceDataParsed[16]);
        public static Trait StoutResilience = new Trait(sourceDataParsed[17]);
        #endregion
        #region Dragonborn
        public static Trait BreathWeapon = new Trait(sourceDataParsed[18]);
        public static Trait DamageResistence = new Trait(sourceDataParsed[19]);
        #endregion
        #region Gnome
        public static Trait GnomeDarkvision = new Trait(sourceDataParsed[20]);
        public static Trait GnomeCunning = new Trait(sourceDataParsed[21]);
        public static Trait ArtificersLore = new Trait(sourceDataParsed[22]);
        public static Trait Tinker = new Trait(sourceDataParsed[23]);
        public static Trait SpeakWithSmallBeasts = new Trait(sourceDataParsed[24]);
        #endregion
        #region Half Elf
        public static Trait HalfElfDarkvision = new Trait(sourceDataParsed[25]);        
        #endregion
        #region Half Orc
        public static Trait HalfOrcDarkvision = new Trait(sourceDataParsed[26]);
        public static Trait Menacing = new Trait(sourceDataParsed[27]);
        public static Trait RelentlessEndurance = new Trait(sourceDataParsed[28]);
        public static Trait SavageAttacks = new Trait(sourceDataParsed[29]);
        #endregion
        #region Tiefling
        public static Trait TieflingDarkvision = new Trait(sourceDataParsed[30]);
        public static Trait HellishResistance = new Trait(sourceDataParsed[31]);
        public static Trait InfernalLegacy = new Trait(sourceDataParsed[32]);
        #endregion

        private static List<KeyValuePair<string, string>> parseSourceData()
        {
            string source;
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("SourceData.txt"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                source = reader.ReadToEnd();
            }

            string[] partiallyParsedData = source.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<KeyValuePair<string, string>> parsedData = new List<KeyValuePair<string, string>>();

            foreach (string entry in partiallyParsedData)
            {
                if (entry.Substring(0,1) != "#")
                {
                    string[] parsedEntry = entry.Split('|');
                    parsedData.Add(new KeyValuePair<string, string>(parsedEntry[0].Trim(), parsedEntry[1].Trim()));
                }
            }

            return parsedData;
        }
    }
}
