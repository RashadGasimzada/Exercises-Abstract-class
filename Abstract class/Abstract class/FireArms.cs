using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class
{
    public abstract class FireArms:Weapon
    {
        public string TrunkLength { get; set; }
        public string Caliber { get; set; }
        public string NumberOfBarrels { get; set; }
    }
}
