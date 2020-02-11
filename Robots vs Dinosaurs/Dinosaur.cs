using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        //Member Variables has a

        public string typeOfDino;
        public int health;
        public int attackPower;
        public int energy;

        // constructor spawn
        public Dinosaur(string typeOfDino, int health, int attackPower, int energy)
        {
            this.typeOfDino = typeOfDino;
            this.health = health;
            this.attackPower = attackPower;
            this.energy = energy;
        }

        //methods can do
        //attack if something
        //dodge if something
        //died
       
        public void AttackRobot(Robots robots)
        {
            robots.health -= attackPower;
        }
    }
}
