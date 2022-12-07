using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ProcessInput
    {
        public static string Run(string consoleOutput, List<string> LegitimateChoices, List<string> MenuChoices, Yuzo yuzo)
        {
            Console.WriteLine(consoleOutput);
            var userInput = Console.ReadLine().ToLower();

            if (LegitimateChoices.Contains(userInput))
            {
                return userInput;
            }
            if (MenuChoices.Contains(userInput))
            {
                Menu.Run(userInput, yuzo);
                return null;
            }
            //if (YesNoChoices.Contains(userInput))
            //{
            //    return userInput;
            //}
            return Run("Versuchs erneut", LegitimateChoices, MenuChoices, yuzo);
        }
    }
}