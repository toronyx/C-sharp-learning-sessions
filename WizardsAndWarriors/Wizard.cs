using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsAndWarriors
{
    internal class Wizard : Character
    {
        private bool spellPrepared = false;
        public override string Type => "Wizard";

        public Wizard(string name) : base(name) { }

        public override bool Vulnerable()
        {
            return !spellPrepared;
        }

        public void PrepareSpell()
        {
            spellPrepared = true;
        }

        public void CastSpell()
        {
            spellPrepared = false;
        }

        public override int DamagePoints(Character target)
        {
            return spellPrepared ? 12 : 3;
        }
    }
}
