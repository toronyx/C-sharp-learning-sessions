namespace Csharpsessions.DesignPatterns.State
{
    public class StateChallenge : IChallenge
    {
        void IChallenge.Run()
        {
            throw new NotImplementedException();
        }
    }

    //Create a shop till! Start with creating a state for scanning items and then paying for them.

    public class ShopTill
    {
        IShopTillState state;

        ShopTill()
        {
            state = new Scanning();
        }
    }

    public interface IShopTillState
    {
        void ScanItem(string item);
        void Pay(out IShopTillState newState);
        void Cancel();
    }

    public class Scanning : IShopTillState
    {
        private List<string> items = new();

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Pay(out IShopTillState newState)
        {
            newState = new Paying(items);
        }

        public void ScanItem(string item)
        {
            items.Add(item);
        }
    }

    public class Paying : IShopTillState
    {
        int cost;

        public Paying(List<string> items)
        {
            cost = items.Count;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void ScanItem(string item)
        {
            throw new NotImplementedException();
        }

        public void Pay(out IShopTillState newState)
        {
            throw new NotImplementedException();
        }
    }
}
