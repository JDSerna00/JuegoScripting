using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    internal class Enemy : IDealDamage
    {
        Vector3 position;
        int lives;
        int power;

        public void Destroyed()
        {

        }

        void IDealDamage.DealDamage()
        {
            throw new NotImplementedException();
        }

        void IDealDamage.TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
