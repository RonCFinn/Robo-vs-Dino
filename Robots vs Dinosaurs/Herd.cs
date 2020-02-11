using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    //member variables (has a)
    //
    public class Herd
    {

        public Dinosaur Dino1 = new Dinosaur("Triceratops", 100, 25, 100);
        public Dinosaur Dino2 = new Dinosaur("T-Rex", 100, 50, 100);
        public Dinosaur Dino3 = new Dinosaur("Raptor", 100, 25, 100);
        public List<Dinosaur> Dino;
        public bool dinoDies;

        //constucter spwn
        public Herd()
        {
            Dino = new List<Dinosaur>();
            Dino.Add(new Dinosaur("Triceratops", 100, 25, 100));
            Dino.Add(new Dinosaur("T-Rex", 100, 50, 100));
            Dino.Add(new Dinosaur("Raptor", 100, 25, 100));
        }





        // method can do these things
        //if something happens
        //for loop possibly
        public void dinoState()
        {
            for(int i = 0; i < Dino.Count; i++)
            {
                if (Dino[i].health <= 0)
                {
                    Dino.Remove(Dino[i]);
                    i--;
                    Console.WriteLine("Dinosaur's Loose");
                }

            }

            if(Dino.Count == 0)
            {
                dinoDies = true;
            }
        }

    }   
}
