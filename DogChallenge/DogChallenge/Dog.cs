namespace DogChallenge
{
    internal abstract class Dog: IBark, IFetch
    {
        public Dog()
        {
            BarkCount = 0;
        }

        public string BarkCommand => "Speak!";

        public int BarkCount { get; private set; }

        public abstract string BarkType { get; }

        public string FetchCommand => "Fetch!";

        public abstract float FetchSpeed { get; }

        public bool TryBark()
        {
            if (BarkCommand != "")
            {
                BarkCount++;
                return true;
            }
            return false;
        }

        public bool TryFetch()
        {
            return (FetchCommand != "") && (FetchSpeed > 0f);
        }
    }
}
