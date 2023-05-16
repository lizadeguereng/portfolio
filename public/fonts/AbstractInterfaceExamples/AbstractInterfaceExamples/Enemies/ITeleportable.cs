using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal interface ITeleportable
    {
        public void JumpTo(int newX, int newY);
    }
}
