using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharGen.Base.SourceData.Equipment.Weapons;

namespace DndCharGen.Base.SourceData.Equipment
{
    public class Weapon : Equipment
    {
        private int numberOfDice;
        public int NumberOfDice
        {
            get { return numberOfDice; }
        }

        private int damageDie;
        public int DamageDie
        {
            get { return damageDie; }
        }

        private DamageType damageType;
        public DamageType DamageType
        {
            get { return DamageType; }
        }

        private List<Property> properties;
        public List<Property> Properties
        {
            get { return properties; }
        }

        public Weapon(string name, int weight, int cost, int numOfDice, int damageDice, DamageType damageType, List<Property> properties)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            this.numberOfDice = numOfDice;
            this.damageType = damageType;
            this.properties = properties;
        }
    }

    public enum DamageType
    {
        Bludgeoning,
        Slashing,
        Piercing
    }
}
