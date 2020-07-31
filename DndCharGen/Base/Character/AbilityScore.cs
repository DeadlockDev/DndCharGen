using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.Character
{
    public class AbilityScore
    {
        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Modifier
        {
            get
            {
                return (Score - 10) / 2;
            }
        }
    }
}
