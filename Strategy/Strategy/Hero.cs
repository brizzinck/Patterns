using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero
    {
        private readonly string _name;
        private IWeapon? _weapon;
        public Hero(string name)
        {
            _name = name;
        }
        public void SetWepon(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack()
        {
            Console.WriteLine(">>>");
            if (_weapon == null)
            {
                Console.WriteLine("Weapon = null");
                return;
            }
            _weapon.Shoot();
        }
    }
}
