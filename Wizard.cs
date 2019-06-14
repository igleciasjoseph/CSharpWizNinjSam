using System;
using System.Collections.Generic;


namespace WizNinSam
{
    class Wizard : Human {
        public Wizard(string name, int str, int intel, int dex, int hp) : base(name, str, 25, dex, 50) {
            
        }

        public override int Attack(Human target) {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            this.health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int Heal(Human target) {
            target.Intelligence += 10;
            return target.Intelligence;
        }
    }
}
