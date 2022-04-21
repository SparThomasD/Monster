using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    abstract class Undead : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public Undead() : base()
        {
            this.Darkvision = true;
            this.Resistances += "Necrotic ";
        }

        public bool Darkvision { get; private set; }
        public string Resistances { get; private set; }
        /* Methods */
    }
}
