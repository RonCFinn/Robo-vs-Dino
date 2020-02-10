using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    public class Dino
    {
        //MemVars

        public string Name;
        public int Health;
        public int Power;
        public string DinoWeapon;
        public int DinoAttackDamage;
        public int DinoAttackPowerCost;

        //ConStruct

        public Dino(string type, int health, int power, string dinoWeapon, int dinoAttackDmg, int PowerCost)
        {
            Name = type;
            Health = health;
            Power = power;
            DinoWeapon = dinoWeapon;
            DinoAttackDamage = dinoAttackDmg;
            DinoAttackPowerCost = PowerCost;
        }
        //MemMethods

        public void Attack(Robot robot)
        {

        }
    }
}
