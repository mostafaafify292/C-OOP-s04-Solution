﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Part3_Q1_Q2_Q3
{
    internal class CircleClass : ICircle
    {
        public double Area { get ;  }

       

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Shape Info");
        }

        public override string ToString()
        {
            return $" Area Of Circle = {Area}";
        }
    }
}
