using System;
using System.Collections.Generic;
using System.Text;
using AnimalProject.Abstract;
namespace AnimalProject.Models
{
    class Swan : Bird, IFly , ISwim
    {
        public void CanFly()
        {
            Console.WriteLine("Swan can fly");
        }

        public void CanSwim()
        {
            Console.WriteLine("Swan even can swim");
        }
    }
}
