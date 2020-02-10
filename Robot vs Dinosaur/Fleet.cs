using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    public class Fleet
    {
        //MemVars
        public List<Robot> Baddies = new List<Robot>();
        public List<Weapon> Weapons = new List<Weapon>();
        //Construct

        public Fleet()
        {
            Weapons.Add(new Weapon("Melee", 5));
            Weapons.Add(new Weapon("Staff", 15));
            Weapons.Add(new Weapon("Bow", 10));

            Baddies = new List<Robot>();
        }
        //MemMethods

        public void CharacterSelection()
        {
            Console.WriteLine("Select Robot Type: Tank, Mage, or Guard");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Tank":
                    Baddies.Add(new Robot("Tank", 230, 150, "Melee", 5, 2));
                    break;
                case "Mage":
                    Baddies.Add(new Robot("Mage", 155, 225, "Staff", 15, 12));
                    break;
                case "Guard":
                    Baddies.Add(new Robot("Guard", 185, 185, "Bow", 10, 7));
                    break;
                default:
                    Console.WriteLine("You Must Choose Robot Type: Tank, Mage, or Guard!");
                    break;
            }

        }
    }
}
