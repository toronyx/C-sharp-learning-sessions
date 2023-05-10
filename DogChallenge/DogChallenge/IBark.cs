namespace DogChallenge
{
    internal interface IBark
    {
        public string BarkCommand { get; }
        public int BarkCount { get; }
        public string BarkType { get; }

        public bool TryBark();
    }
}
