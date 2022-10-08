using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Water Gun Attack");
        }
    }
}
