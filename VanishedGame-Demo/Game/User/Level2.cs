using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Level2
    {
        public static List<string> Level2Choices = new List<string> { "fremder", "inschrift", "teich" };
        public static List<string> MenuChoices = new List<string> { "reset", "quit", "waffe", "inventar", "hp", "xp" };
        public static List<string> YesNoChoices = new List<string> { "ja", "nein" };
        public static void IntroLevel2(Yuzo yuzo)
        {
            Console.WriteLine("\nDu wirst geblendet von dem Licht.");
            BattleLevel2(yuzo);
        }
        public static void BattleLevel2(Yuzo yuzo)
        {
            Console.WriteLine("Du wirst von einem betrunkenem Fremden entdeckt der auf dich zuläuft.\nEr versucht dich anzugreifen.");

            DrunkStranger drunkStranger = new DrunkStranger();
            drunkStranger.HealthPoints = 40;
            drunkStranger.DrunkStrangersWeapon = new Weapon { Name = "Fäuste", Damage = 5, Attack = "Schlägt Yuzo mit seinen Fäusten" };

            Battle.BattleStart(yuzo, drunkStranger);
            StartLevel2(yuzo);
        }
        public static void StartLevel2(Yuzo yuzo)
        {
            GameText.IntroductionLevel2();
        }
    }
}
