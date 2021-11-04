using System;
using System.Collections.Generic;
using System.Text;
using AnimalProject.Abstract;

namespace AnimalProject.Models
{
    class Amphibian : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as animal");
        }

        public override void Live()
        {
            Console.WriteLine("Live as animal");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep as animal");
        }
    }
}
