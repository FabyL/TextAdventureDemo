using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Level1
    {
        public static List<string> MenuChoices = new List<string> { "reset", "quit", "waffe", "inventar", "hp", "xp", "trinken" };
        public static List<string> YesNoChoices = new List<string> { "ja", "nein" };
        public static List<string> Level1Choices = new List<string> { "bett", "korb", "flasche", "verlassen", "reset", "quit", "waffe", "inventar", "hp", "xp", "trinken"};
        public Yuzo yuzo { get; set; }
        public Cave cave { get; set; }
        public void PlayLevel1()
        {
           var Choice = ProcessInput.Run("\nWas willst du tun ?: (Gebe Inventar, Bett, Korb, Flasche, Waffe oder HP ein, um damit zu interagieren.)", Level1Choices, MenuChoices, yuzo);

            if(Choice != null)
            {
                switch (Choice)
                {
                    case "bett":
                        GoToBedLevel1();
                        PlayLevel1();
                        break;
                    case "korb":
                        GoToBasketLevel1();
                        PlayLevel1();
                        break;
                    case "flasche":
                        GoToBottleLevel1();
                        PlayLevel1();
                        break;
                    case "verlassen":
                        LeaveCave();
                        break;
                    case "quit":
                        QuitGame(yuzo);
                        break;
                    case "reset":
                        Console.WriteLine("\n");
                        Adventure.StartGame();
                        break;
                    case "trinken":
                        yuzo.UseBottle();
                        PlayLevel1();
                        break;
                    case "hp":
                        ShowHP(yuzo);
                        PlayLevel1();
                        break;
                    case "xp":
                        ShowXP(yuzo);
                        PlayLevel1();
                        break;
                    case "inventar":
                        OpenInventory(yuzo);
                        PlayLevel1();
                        break;
                    case "waffe":
                        InspectWeapon(yuzo);
                        PlayLevel1();
                        break;
                    default:
                        GameText.InvalidChoice();
                        PlayLevel1();
                        break;
                }
            }
        }
        public void QuitGame(Yuzo yuzo)
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
                    break;
                default:
                    Console.WriteLine("Bitte wähle eine Möglichkeit aus.");
                    QuitGame(yuzo);
                    break;
            }
        }
        public void ShowHP(Yuzo yuzo)
        {
            Console.WriteLine("Du hast {0} Leben", yuzo.HealthPoints);
        }
        public static void ShowXP(Yuzo yuzo)
        {
            Console.WriteLine("Du bist Level {0} und hast {1}XP", yuzo.YuzoLevel, yuzo.ExperiencePoints);
        }
        public void OpenInventory(Yuzo yuzo)
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
        }
        public void InspectWeapon(Yuzo yuzo)
        {
            if (yuzo.YuzosWeapon != null)
            {
                Console.WriteLine($"Name: {yuzo.YuzosWeapon.Name}, Schaden: {yuzo.YuzosWeapon.Damage}, Angriff: {yuzo.YuzosWeapon.Attack}");
            }
            else
            {
                Console.WriteLine("Du hast keine Waffe.");
            }
        }
            public void GoToBedLevel1()
        {
            var Choice = ProcessInput.Run("\nDu stehst vor dem Bett. Möchtest du ein schläfchen machen? (Schreib: Ja/Nein)", Level1Choices.Concat(YesNoChoices).ToList(), MenuChoices, yuzo);

            if (yuzo.YuzosWeapon == null)
            {
                switch (Choice)
                {
                    case "ja":
                        FindStickLevel1();
                        break;
                    case "nein":
                        Console.WriteLine("Du gehst wieder vom Bett weg.");
                        break;
                    default:
                        GameText.InvalidInput();
                        GoToBedLevel1();
                        break;
                }
            }
            else
            {
                switch (Choice)
                {
                    case "ja":
                        Console.WriteLine("Du fühlst dich nach dem Schlaf erholt.");
                        break;
                    case "nein":
                        Console.WriteLine("Du gehst wieder vom Bett weg.");
                        break;
                    default:
                        GameText.InvalidInput();
                        GoToBedLevel1();
                        break;
                }
            }
        }
        public void FindStickLevel1()
        {
            if (yuzo.YuzosWeapon == null)
            {
                Console.WriteLine("Zwischen den Laken findest du ein Ast.");
                var Choice = ProcessInput.Run("\nMöchtest du den Ast mitnehmen? (Schreib: Ja/Nein)", Level1Choices.Concat(YesNoChoices).ToList(), MenuChoices, yuzo);

                switch (Choice)
                {
                    case "ja":
                        yuzo.YuzosWeapon = cave.Stick;
                        cave.Stick = null;
                        Console.WriteLine("Du hast den Ast mitgenommen.");
                        Console.WriteLine("Gebe Waffe ein, um deine Waffe anzuschauen.");
                        break;
                    case "nein":
                        Console.WriteLine("Du lässt den Ast liegen.");
                        break;
                    default:
                        GameText.InvalidInput();
                        FindStickLevel1();
                        break;
                }
            }
        }
        public void GoToBasketLevel1()
        {
            if (!cave.basketStanding)
            {
                Console.WriteLine("\nDu hast den Korb schon mitgenommen.");
            }
            else
            {
                var Choice = ProcessInput.Run("\nDer Korb ist leer. Möchtest du den Korb mitnehmen? (Schreib: Ja/Nein)", Level1Choices.Concat(YesNoChoices).ToList(), MenuChoices, yuzo);
                switch (Choice)
                {
                    case "ja":
                        cave.Basket = null;
                        yuzo.Inventory = new Item[5];
                        Console.WriteLine("Du nimmst den Korb mit.");
                        break;
                    case "nein":
                        Console.WriteLine("Du lässt den Korb stehen.");
                        break;
                    default:
                        GameText.InvalidInput();
                        GoToBasketLevel1();
                        break;
                }
            }
        }
        public void GoToBottleLevel1()
        {
            if (!cave.bottleStanding)
            {
                Console.WriteLine("\nDu hast die Flasche schon mitgenommen.");
            }
            else
            {
                var Choice = ProcessInput.Run("\nDie Flasche ist mit Wasser gefüllt. Möchtest du die Flasche mitnehmen? (Schreib: Ja/Nein)", Level1Choices.Concat(YesNoChoices).ToList(), MenuChoices, yuzo);

                if (cave.bottleStanding && yuzo.Inventory != null)
                {
                    switch (Choice)
                    {
                        case "ja":
                            cave.Bottle = null;
                            yuzo.Take(new PumpkinBottle());
                            Console.WriteLine("Du verstaust die Flasche in den Korb. \n(Gebe Inventar ein um dir die Flasche anzusehen)");
                            break;
                        case "nein":
                            Console.WriteLine("Du lässt die Flasche stehen");
                            break;
                        default:
                            GameText.InvalidInput();
                            GoToBasketLevel1();
                            break;
                    }
                }
                else
                {
                    switch (Choice)
                    {
                        case "ja":
                            Console.WriteLine("\nVielleicht kannst du die Flasche mitnehmen, wenn du sie verstauen kannst.");
                            break;
                        case "nein":
                            Console.WriteLine("Du lässt die Flasche liegen.");
                            break;
                        default:
                            GameText.InvalidInput();
                            GoToBottleLevel1();
                            break;
                    }
                }
            }
        }
        public void LeaveCave()
        {
            if (yuzo.Inventory != null && yuzo.Inventory.Contains(cave.Bottle) && yuzo.YuzosWeapon != null)
            {
                Level2.IntroLevel2(yuzo);
            }
            else
            {
                Console.WriteLine("\nDu solltest dich noch umgucken, vielleicht hast du was vergessen was nützlich sein könnte.");
                PlayLevel1();
            }
        }
    }
}