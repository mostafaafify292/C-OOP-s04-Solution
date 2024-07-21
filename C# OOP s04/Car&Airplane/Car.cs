using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Car_Airplane
{
    internal class Car : Vehicle, IMoveable
    {
        public void Backward()
        {
            Console.WriteLine("Car backward on Ground"); 
        }

        public void Forward()
        {
            Console.WriteLine("Car forward on Ground"); 
        }

        public void Left()
        {
            Console.WriteLine("Car left on Ground"); 
        }

        public void Right()
        {
            Console.WriteLine("Car right on Ground");
        }
    }
}
