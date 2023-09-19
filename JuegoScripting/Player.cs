using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    public class Player : Character, IDealDamage
    {
        float invincibleTime;
        float invincibleAmount = 2.0f;
        private bool isInvicible;
        private GameManager gameManager;

        public Player(int power, GameManager gameManager) : base(3)
        {
            this.power = power;
            this.gameManager = gameManager;
        }

        public void Movement()
        {

        }

        public void PowerUp(int powerQuantity)
        {
            power += powerQuantity;
        }
        public void DealDamage(IDealDamage target)
        {
            if (target is Enemy)
            {
                (target as Enemy).TakeDamage(1);
                power += (target as Enemy).power;
            }
        }

        public new void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                if (isInvicible)
                    return;

                isInvicible = true;
                invincibleTime = invincibleAmount;
            }

            if (lives > 0)
            {
                lives -= damage;
            }

            if (lives <= 0)
            {
                Destroyed();
                gameManager.EndGame();
            }
        }

        public void RestartPlayer()
        {
            lives = 3;
            power = 0;
        }

        public override void Destroyed()
        {
            Console.WriteLine("Player is dead");
        }
    }
}
