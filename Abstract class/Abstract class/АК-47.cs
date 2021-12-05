using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class
{
    public class АК_47:FireArms
    {
        public override void ShootingSound()
        {
            Console.WriteLine("Pow Pow");
        }

        public override void Shooting()
        {
            Console.WriteLine("Bullet consumption is 5 per second");
        }
    }
}
