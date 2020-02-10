using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    public class Robot
    {
        //MemVars

        public string Name;
        public int Health;
        public int Power;
        public string RobotWeapon;
        public int RobotAttackDamage;
        public int RobotAttackPowerCost;

        //Constructor

        public Robot(string type, int health, int power, string robotWeapon, int robotAttackDmg, int PowerCost)
        {
            Name = type;
            Health = health;
            Power = power;
            RobotWeapon = robotWeapon;
            RobotAttackDamage = robotAttackDmg;
            RobotAttackPowerCost = PowerCost;
        }
        //MemMethods

        public void Attack(Dino dino)
        {

        }

    }
}






