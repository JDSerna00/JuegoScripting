using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JuegoScripting
{
    public class Collectible
    {
        Vector3 position;
        int powerQuantity;

        public void PickUp(Player player)
        {
            player.PowerUp(powerQuantity);
        }
    }
}
