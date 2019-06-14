using System;
using System.Collections.Generic;


namespace WizNinSam
{
    class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int dex, int hp) : base(name, str, intel, 175, hp) {

        }

        public override int Attack(Human target) {
            Random percent = new Random();
            int dmg = Dexterity * 3;
            target.health -= dmg;
            for (int i = 0; i < 100; i++) {
                int dmgChance = 10;
                int percentChance = percent.Next(100);
                if (percentChance < dmgChance) {
                    target.health -= dmgChance;
                }
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int Steal(Human target) {
            target.health -= 5;
            this.health += 5;
            return this.health;
        }
    }
}
