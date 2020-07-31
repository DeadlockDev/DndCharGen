using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharGen.Base.Character
{
    public class ProficientValue
    {
        private bool isProficient;
        public bool IsProficient
        {
            get { return isProficient; }
            set { isProficient = value; }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
