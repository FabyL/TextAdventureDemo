using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class CaveExitLevel2
    {
        public DrunkStranger drunkStranger;
        class Pond
        {
            public int MaxHeal;
            public int RefillBottleUses;
        }
        public string Inscription;
        public Note note;

        private CaveExitLevel2()
        {
            Inscription = "Greif ihn an";
        }
    }
}