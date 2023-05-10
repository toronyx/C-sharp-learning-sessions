using DogChallenge;

SleepyDog sleepyDog = new();
FrenchBulldog liza = new();

if (liza.TryFetch())
{
    Console.WriteLine("Liza fetched!");
}
else
{
    Console.WriteLine("Liza did not fetch!");
}

if (sleepyDog.TryFetch())
{
    Console.WriteLine("Sleepy dog fetched!");
}
else
{
    Console.WriteLine("Sleepy dog did not fetch!");
}

for (int i = 0; i < 5; i++)
{
    if (liza.TryBark())
    {
        Console.WriteLine($"Liza barked, she has barked {liza.BarkCount} times");
    }
}