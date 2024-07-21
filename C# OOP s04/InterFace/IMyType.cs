using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.InterFace
{
    internal interface IMyType
    {
        public int Id { get; set; }
        public void Myfun(int x);

        public void print()
        {
            Console.WriteLine("defult implemented method");
        }


    }
}
