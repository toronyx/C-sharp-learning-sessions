using WizardsAndWarriors;

static void PrintDamage(
    Character character, 
    Character target)
{
    Console.WriteLine(
        $"{character.Name} did " +
        $"{character.DamagePoints(target)} damage to " +
        $"{target.Name}");
};

Wizard wizard = new("Wizard");
Warrior warrior = new("Warrior");

PrintDamage(wizard, warrior);
PrintDamage(warrior, wizard);
wizard.PrepareSpell();
Console.WriteLine($"{wizard.Name} is preparing a spell!");
PrintDamage(warrior, wizard);
PrintDamage(wizard, warrior);
