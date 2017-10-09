﻿    public class Assassin : AbstractHero
{
        public Assassin(string name) 
            : base(name)
        {
            this.Strength = 25;
            this.Agility = 100;
            this.Intelligence = 15;
            this.HitPoints = 150;
            this.Damage = 300;

        }
    }