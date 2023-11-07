I've created a format for each coding challenge that is done as part of a C# session.

`Program.cs` will always involve creating an object that implements `IChallenge`, and then calling the `Run()` method on that `IChallenge`.

Each challenge will define a class that implements `IChallenge`, e.g. a LINQ challenge might make a `public class LinqChallenge : IChallenge`.

The `IChallenge` interface includes a public `Run()` method, which is meant to hold all of the stuff you'd usually dump straight into `Program.cs`, i.e. any log messages, local variables, or other non-class stuff.