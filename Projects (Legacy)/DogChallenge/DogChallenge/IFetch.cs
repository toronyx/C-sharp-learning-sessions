namespace DogChallenge
{
    internal interface IFetch
    {
        public string FetchCommand { get; }
        public float FetchSpeed { get; }

        public bool TryFetch();
    }
}
