using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    abstract class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; } 
        public virtual void Attack()
        {
            Console.WriteLine("The enemy attacks you and you lose 10hp");
        }
    }
}
