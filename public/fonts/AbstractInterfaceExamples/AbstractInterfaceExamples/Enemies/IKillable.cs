using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceExamples.Enemies
{
    internal interface IKillable
    {
        public void TakeDamage(int damageAmount);
        public void Die();
    }
}
