using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.Part3_Q1_Q2_Q3
{
    internal class RectanangleClass : IRectangle
    {
        
        public double Width { get; set ; }
        public double Length { get; set ; }
        public double Area { get { return Width * Length; } }

      

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width = {Width} , Lenght = {Length} , Area = {Area}");
        }
        public override string ToString()
        {
            return $" Area Of Rectanangle = {Area}";
        }
    }
}
