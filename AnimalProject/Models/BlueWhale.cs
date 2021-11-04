using System;
using System.Collections.Generic;
using System.Text;
using AnimalProject.Abstract;
namespace AnimalProject.Models
{
    class BlueWhale : Amphibian, ISwim , ISwimSpeed
    {
        public int SwimSpeed { get; set; }

        public void CanSwim()
        {
            Console.WriteLine("BlueWhale can swim");
        }

        public void SwimSp()
        {
            Console.WriteLine("Blue Whale Swim very slow");
        }
    }
}
