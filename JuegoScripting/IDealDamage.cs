using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    public interface IDealDamage
    {
        int GetPower();
        public void DealDamage(IDealDamage target);
        public void TakeDamage(int damage);
    }
}
