﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeroTypes
{
    public class Warrior : Hero
    {
        static string nameClass = "Warrior";
        static int maxHealth = 50;
        static int waveReached = 1;
        static int timesPlayed = 0;
        static bool hasWon = false;

        new public int health = Warrior.maxHealth;
    }

    public class Mage : Hero
    {
        static string nameClass = "Mage";
        static int maxHealth = 20;
        static int waveReached = 1;
        static int timesPlayed = 0;
        static bool hasWon = false;

        new public int health = Mage.maxHealth;
    }

    public class Archer : Hero
    {
        static string nameClass = "Archer";
        static int maxHealth = 30;
        static int waveReached = 1;
        static int timesPlayed = 0;
        static bool hasWon = false;

        new public int health = Archer.maxHealth;
    }
}

