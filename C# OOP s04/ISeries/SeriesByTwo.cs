using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04.ISeries
{
    internal class SeriesByTwo : Iseries
    {
        public int Current { get ; set ; }

        public void GetNext()
        {
            Current += 2;
        }

       
    }
}
