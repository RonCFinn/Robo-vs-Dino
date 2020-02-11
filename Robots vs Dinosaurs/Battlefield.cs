using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Battlefield
    {
        class field
        {
            // member variables (HAS A)

            Herd theHerd;
            Fleet theFleet;




            // constructor (SPAWNER)
            public field()
            {
                this.theFleet = new Fleet();
                this.theHerd = new Herd();
                StartBattlefield();
                Battle();
                Console.ReadLine();
            }
            // member methods (CAN DO)

            public void StartBattlefield()

            {
                Console.WriteLine("START");

            }

            public void Battle()
            {



                while (theHerd.dinoDies != true && theFleet.botsDies != true)

                {


                    for (int i = 0; i < theHerd.Dino.Count; i++)
                    {

                        theHerd.Dino[i].AttackRobot(theFleet.bots[0]);
                        Console.WriteLine("Attacking");
                        Console.ReadLine();

                    }

                    for (int i = 0; i < theFleet.bots.Count; i++)
                    {
                        theFleet.bots[i].AttackDino(theHerd.Dino[0]);

                        Console.WriteLine("Attacking");
                        Console.ReadLine();

                    }

                    theHerd.dinoState();
                    theFleet.botState();



                }


            }










        }


    }
} 
