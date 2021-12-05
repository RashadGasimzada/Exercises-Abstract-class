using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class
{
    public abstract class Weapon
    {
        public string WeaponName { get; set; }
        public string WeaponType { get; set; }
        public string WeaponSize { get; set; }

        public abstract void ShootingSound();
        public virtual void Shooting ()
        {
            Console.WriteLine("Bullet consumption");
        }
    }
}
