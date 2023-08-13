using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    internal class Player : IDealDamage
    {
        Vector3 position;
        int lives;
        int power;
        float invincibleTime;
        bool isinvicible;

        public void Movement()
        {

        }

        public void PowerUp()
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
