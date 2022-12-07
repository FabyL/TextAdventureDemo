﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameText
    {
        public static void IntroductionLevel1()
        {
            Console.WriteLine("Du befindest dich in einer Höhle und dein schädel brummt.\nDu kannst dich an nichts mehr erinnern und siehst dich um.\nDu siehst: Ein improvisiertes Bett, einen gefüllten Tragekorb und eine Kürbisflasche.\nWenn du bereit bist kannst du die Höhle verlassen. (Gebe dafür verlassen ein)\nWenn du das Spiel beenden möchtest, schreibe: Quit");
        }
        public static void IntroductionLevel2()
        {
            Console.WriteLine("\nHier hört die Demo auf. Wie würdest du weiter machen?\n");
        }
        public static void InvalidChoice()
        {
            Console.WriteLine("Bitte gebe nur die bereits genannten Commands ein.");
        }
        public static void InvalidInput()
        {
            Console.WriteLine("Bitte versuche es erneut.");
        }
    }
}