using System;
using AnimalProject.Abstract;
using AnimalProject.Models;

namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {
        TryAgain:
            Console.WriteLine("\nPlease enter Animal \n1 for Swan \n2 for BlueWhale \n3 for chicken");
            string input = Console.ReadLine();

            
            switch (input)
            {
                case "1":
                    ForSwan();
                    goto TryAgain;
                case "2":
                    ForBlueWhale();
                    goto TryAgain;
                case "3":
                    ForChicken();
                    goto TryAgain;
                default:
                    Console.WriteLine("Please enter right input !");
                    goto TryAgain;
            }


        }

        public static void ForBlueWhale()
        {
            BlueWhale bluewhale = new BlueWhale();
            bluewhale.CanSwim();
            bluewhale.SwimSp();
        }
        public static void ForSwan()
        {
            Swan swan = new Swan();
            swan.Eat();
            swan.CanFly();
            swan.Sleep();
            swan.CanSwim();

        }

        public static void ForChicken()
        {
            Chicken chicken = new Chicken();
            chicken.Eat();
            chicken.CanFly();
            chicken.Sleep();

        }

    }
}
