using System;
using System.Collections.Generic;


namespace WizNinSam
{
    class Samurai : Human
    {
        public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, 200) {

        }

        public override int Attack(Human target) {
            base.Attack(target);
            if (this.health < 50) {
                target.health = 0;
            }
            return target.health;
        }

        public int Meditate(Human target) {
            this.health = 100;
            return this.health;
        }
    }
}