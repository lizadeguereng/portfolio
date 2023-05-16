using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal interface IMovable
    {
        public void MoveNorth(int distance);
        public void MoveSouth(int distance);    
        public void MoveEast(int distance);
        public void MoveWest(int distance);
        public void ReportLocation();
    }
}
