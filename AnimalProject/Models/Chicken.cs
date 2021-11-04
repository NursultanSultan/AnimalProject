using System;
using System.Collections.Generic;
using System.Text;
using AnimalProject.Abstract;

namespace AnimalProject.Models
{
    class Chicken : Bird, IFly
    {
        public void CanFly()
        {
            Console.WriteLine("Chicken is bird but cant fly");
        }

       
    }
}
