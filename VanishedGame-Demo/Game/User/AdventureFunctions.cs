//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Game
//{
//    class AdventureFunctions
//    {
//        public static void Run(string userInput, Yuzo yuzo, Cave cave)
//        {
//            switch (userInput)
//            {
//                case "bett":
//                    Level1.GoToBedLevel1(yuzo, cave);
//                    break;
//                case "korb":
//                    Level1.GoToBasketLevel1(yuzo, cave);
//                    break;
//                case "flasche":
//                    Level1.GoToBottleLevel1(yuzo, cave);
//                    break;
//                case "trinken":
//                    yuzo.UseBottle();
//                    Level1.PlayLevel1(yuzo, cave);
//                    break;
//                case "verlassen":
//                    Level1.LeaveCave(yuzo, cave);
//                    break;
//                default:
//                    Run(userInput, yuzo, cave);
//                    break;
//            }
//        }
//    }
//}
