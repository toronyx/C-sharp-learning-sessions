using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsAndWarriors
{
    internal class Warrior : Character
    {
        public override string Type => "Warrior";

        public Warrior(string name) : base(name) { }

        public override bool Vulnerable()
        {
            return base.Vulnerable();
        }

        public override int DamagePoints(Character target)
        {
            return target.Vulnerable() ? 10 : 6;
        }
    }
}
