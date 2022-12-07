using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Adventure
    {
        public static void StartGame()
        {
            Level1 firstLevel = LevelGeneration.GenerateLevel1();
            firstLevel.PlayLevel1();
        }
    }
}
