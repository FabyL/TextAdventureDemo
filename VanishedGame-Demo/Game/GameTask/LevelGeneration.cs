﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class LevelGeneration
    {
        public static Level1 GenerateLevel1()
        {
            Cave cave = new Cave
            {
                Stick = new Weapon { Name = "Ast", Damage = 15, Attack = "Schlägt den Gegner mit dem Ast" },
                Basket = new Item[5],
                Bottle = new PumpkinBottle()
            };
            Yuzo yuzo = new Yuzo
            {
                HealthPoints = 50,
                ExperiencePoints = 0
            };
            GameText.IntroductionLevel1();
            return new Level1 { cave = cave, yuzo = yuzo };
        }
    }
}