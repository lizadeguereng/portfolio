using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal interface IBecomeInvisible
    {
        public bool IsVisible { get; set; }
        public void ToggleVisibility();
    }
}
