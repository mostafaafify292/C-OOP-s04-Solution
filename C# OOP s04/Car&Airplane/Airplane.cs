using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Car_Airplane
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
    {
       

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane move backward on air"); 
        }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplane move backward on Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane move foward on air");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane move foward on Ground");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane move left on air");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane move left on Ground");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane move right on air");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplane move right on Ground");
        }
    }
}
