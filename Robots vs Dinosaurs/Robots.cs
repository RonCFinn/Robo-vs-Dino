using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Robots
    {
        // member variable has a
        public string nameOfRobot;
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;

        //constuctor spawn
        public Robots(string nameOfRobot, int health, int powerLevel, string weapon, int attackPower)
        {
            this.nameOfRobot = nameOfRobot;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
        }


        // methods can do
        //attack
        //dodge if something
        public void AttackDino(Dinosaur dinosaur)
        {
            dinosaur.health -= attackPower;
        }
    }
}
