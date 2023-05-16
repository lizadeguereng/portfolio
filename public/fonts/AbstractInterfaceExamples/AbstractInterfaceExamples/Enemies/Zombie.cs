using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal class Zombie : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Zombie touches you with death. Lose 50%hp.");
        }
    }
}
