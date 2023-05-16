using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal interface IFlyable
    {
        public int Altitude { get; set; } 
        public void Climb(int AscendThisAmount);
        public void Descend(int DescendThisAmount);
         
    }
}
