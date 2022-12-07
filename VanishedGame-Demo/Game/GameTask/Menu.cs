﻿using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Menu
    {
        public static void Run(string userInput, Yuzo yuzo)
        {
            //switch(userInput)
            //{
            //    case "quit":
            //        QuitGame(yuzo/*, cave*/);
            //        break;
            //    case "reset":
            //        Console.WriteLine("\n");
            //        Adventure.StartGame();
            //        break;
            //    case "trinken":
            //        yuzo.UseBottle();
            //        PlayLevel1();
            //        break;
            //    case "hp":
            //        ShowHP(yuzo/*, cave*/);
            //        PlayLevel1();
            //        break;
            //    case "xp":
            //        ShowXP(yuzo/*, cave*/);
            //        PlayLevel1();
            //        break;
            //    case "inventar":
            //        OpenInventory(yuzo/*, cave*/);
            //        PlayLevel1();
            //        break;
            //    case "waffe":
            //        InspectWeapon(yuzo/*, cave*/);
            //        PlayLevel1();
            //        //Level1.PlayLevel1(yuzo, cave);
            //        break;
            //}
        }
        public static void QuitGame(Yuzo yuzo/*, Cave cave*/)
        {
            Console.WriteLine("Möchtest du das Spiel beenden? (ja/nein)");
            var Choice = Console.ReadLine().ToLower();

            switch (Choice)
            {
                case "ja":
                    Console.WriteLine("Drücke eine beliebige Taste um das Spiel zu beenden.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case "nein":
                    //Level1.PlayLevel1(yuzo, cave);
                    break;
                default:
                    Console.WriteLine("Bitte wähle eine Möglichkeit aus.");
                    QuitGame(yuzo/*, cave*/);
                    break;
            }
        }
        public static void ShowHP(Yuzo yuzo/*, Cave cave*/)
        {
            Console.WriteLine("Du hast {0} Leben", yuzo.HealthPoints);
            //Level1.PlayLevel1(yuzo, cave);
        }
        public static void ShowXP(Yuzo yuzo/*, Cave cave*/)
        {
            Console.WriteLine("Du bist Level {0} und hast {1}XP", yuzo.YuzoLevel, yuzo.ExperiencePoints);
            Level2.StartLevel2(yuzo);
        }
        public static void OpenInventory(Yuzo yuzo/*, Cave cave*/)
        {
            if (yuzo.Inventory != null)
            {
                foreach (var item in yuzo.Inventory)
                {
                    if (item != null)
                    {
                        Console.WriteLine($"Name: {item.Name}, Effekt: {item.EffectDescription}");
                    }                        
                }
            }
            else
            {
                Console.WriteLine("Dein Inventar ist leer.");
            }
            //Level1.PlayLevel1(yuzo, cave);
        }
        public static void InspectWeapon(Yuzo yuzo/*, Cave cave*/)
        {
            if (yuzo.YuzosWeapon != null)
            {
                Console.WriteLine($"Name: {yuzo.YuzosWeapon.Name}, Schaden: {yuzo.YuzosWeapon.Damage}, Angriff: {yuzo.YuzosWeapon.Attack}");
            }
            else
            {
                Console.WriteLine("Du hast keine Waffe.");
            }
            //Level1.PlayLevel1(yuzo, cave);
        }
    }
}