using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs

{
    //create robots in fleet
    public class Fleet
    {//membervariables has a
        
       public Robots robo1 = new Robots("Robo-Cop", 100, 100, "Pistol", 25);
       public Robots robo2 = new Robots("T-1000", 100, 100, "Machine Gun", 50);
       public Robots robo3 = new Robots("R2-D2", 100, 100, "taser", 25);
        public List<Robots>  bots;
        public bool botsDies;
        // constructor

        public  Fleet()
        {
            bots = new List<Robots>();
            bots.Add(new Robots("Robo-Cop", 100, 100, "Pistol", 25));
            bots.Add(new Robots("T-1000", 100, 100, "Machine Gun", 50));
            bots.Add(new Robots("R2-D2", 100, 100, "Taser", 25));

        }

        //method can do
        //for loop? possibly?
        //if something happens robot dies
       // public void IsRobotDead()
        public void botState()
        {
            for (int i = 0; i < bots.Count; i++)
            {
                if(bots[i].health < 0)
                {
                    bots.Remove(bots[i]);
                    i--;
                    Console.WriteLine("Robot' loose");
                   
                }

            }

            if (bots.Count == 0) 
            {
                botsDies = true;
            }

        }
           
    }
}