namespace WizardsAndWarriors
{
    internal abstract class Character
    {
        public string Name { get; }
        public abstract string Type { get; }

        public Character(string characterName)
        {
            Name = characterName;
        }

        public override string ToString()
        {
            return $"Character is a {Type}";
        }

        public virtual bool Vulnerable() => false;

        public abstract int DamagePoints(Character target);
    }
}
