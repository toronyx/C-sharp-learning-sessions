namespace Csharpsessions.Generics
{
    internal static class CoAndContravarianceChallenge
    {
        internal static void Run()
        {
            // Covariance
            Habitat<Dog> dogHabitat = new(new Dog("Liza"));
            Habitat<Cat> catHabitat = new(new Cat("Mimi"));

            // we treat the specific containers (of Dog, Cat) as general containers of Animal
            List<IAnimalContainer<Animal>> containers = new()
            {
                dogHabitat,
                catHabitat
            };

            // we can now iterate through them, but we remain secure knowing that the dog habitat
            // will always contain a dog
            foreach (IAnimalContainer<Animal> container in containers)
            {
                container.PrintOccupant();
            }



            // Contravariance
            IAnimalFeeder<Animal> animalFeeder = new AnimalFeeder<Animal>();

            // general animal feeder is used as a cat feeder
            catHabitat.Feeder = animalFeeder;
            catHabitat.FeedingTime();

            // so why not make the Feeder property of type IAnimalFeeder<Animal>?
            Habitat<Cat> fussyCatHabitat = new(new Cat("Garfield"));
            // well, we want cat-specific ones to be possible as well:
            fussyCatHabitat.Feeder = new LasagnaOven();

            fussyCatHabitat.FeedingTime();
        }
    }

    internal interface IAnimalContainer<out T> where T : Animal
    {
        T Animal { get; }

        internal void PrintOccupant()
        {
            Console.WriteLine($"This {GetType().Name} contains a {typeof(T).Name} called {Animal.Name}");
        }
    }

    class Habitat<T> : IAnimalContainer<T> where T : Animal
    {
        public T Animal { get; }

        public IAnimalFeeder<T>? Feeder { get; set; }

        public Habitat(T animal)
        {
            Animal = animal;
            Feeder = null;
        }

        public void FeedingTime()
        {
            Feeder.FeedAnimal(Animal);
        }
    }

    internal interface IAnimalFeeder<in T> where T : Animal
    {
        internal void FeedAnimal(T animal);
    }

    class AnimalFeeder<T> : IAnimalFeeder<T> where T : Animal
    {
        public void FeedAnimal(T animal)
        {
            Console.WriteLine($"This general purpose feeder seems to work pretty well! {animal.Name}: *monchmonchmonchmonchmonch*...");
        }
    }

    class LasagnaOven : IAnimalFeeder<Cat>
    {
        public void FeedAnimal(Cat animal)
        {
            Console.WriteLine($"Some cats prefer to eat lasagna. {animal.Name}: \"Ahh...nature's most perfect food...\"");
        }
    }

    internal record class Animal(string Name);
    internal record class Dog(string Name) : Animal(Name);
    internal record class Cat(string Name) : Animal(Name);
}
