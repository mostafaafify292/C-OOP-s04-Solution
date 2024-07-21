using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Part3_Q1_Q2_Q3
{
    internal interface IRectangle :IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }

    }
}
