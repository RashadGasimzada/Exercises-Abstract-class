using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class
{
    public class ButterflyKnife:ColdSteel
    {
        public override void ShootingSound()
        {
            Console.WriteLine("No sound");
        }
        public override void Shooting()
        {
            Console.WriteLine("Bullet consumption is zero");
        }
    }
}
