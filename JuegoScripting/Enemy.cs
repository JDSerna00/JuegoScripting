using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    public class Enemy : Character, IDealDamage
    {
        private LevelManager levelManager;
        public Enemy(int power, LevelManager levelManager) : base(1)
        {
            this.power = power;
            this.levelManager = levelManager;
        }

        public void DealDamage(IDealDamage target)
        {
            if (target is Player)
            {
                (target as Player).TakeDamage(1);
                power += (target as Player).power;
            }
        }

        public override void Destroyed()
        {
            if (lives == 0)
            {
                levelManager.RemoveActiveEnemy(this);
            }
        }

        // Start is called before the first frame update
        void AddEnemy()
        {
            levelManager.AddActiveEnemy(this);
        }
    }
}
