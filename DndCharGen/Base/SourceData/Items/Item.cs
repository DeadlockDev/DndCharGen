using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.SourceData.Items
{
    public class Item
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private int cost;
        public int Cost
        {
            get { return cost; }
        }

        private int weight;
        public int Weight
        {
            get { return weight; }
        }

        public Item(string itemName, int itemCost, int itemWeight)
        {
            name = itemName;
            cost = itemCost;
            weight = itemWeight;
        }
    }
}
