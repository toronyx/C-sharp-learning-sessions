namespace Csharpsessions.DesignPatterns.Mediator
{
    public class MediatorChallenge : IChallenge
    {
        public void Run()
        {
            var tcr = new TaxiControlRoom(15);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
            tcr.CreateJob(6);
        }
    }


    interface ITaxiControlRoom
    {
        void CreateJob(double location);
    }
    interface ITaxi
    {
        public double Location { get; }

        public bool Available { get; }

        public void AcceptJob(double location);


    }
    class TaxiControlRoom:ITaxiControlRoom
    {
        private IList<ITaxi> _agents = new List<ITaxi>();
        public TaxiControlRoom (int numberOfTaxis)
        {
            var rand = new Random();
        
            for (int i = 0; i < numberOfTaxis; i++)
            {
                _agents.Add(new Taxi(rand.NextDouble()));
            }
        }
        public void CreateJob(double location)
        {
            ITaxi taxi = _agents.OrderBy(t => Math.Abs(t.Location - location)).First(t => t.Available);
            if (taxi is not null)
            {
                taxi.AcceptJob(location);
            }
        }

    }

    internal class Taxi : ITaxi
    {
        public double Location { get; private set; }

        public bool Available { get; private set; }

        public Taxi (double location)
        {
            Location = location;
            Available = true;
        }
        public void AcceptJob(double location)
        {
            Available = false;
            Location = location;
            Console.WriteLine("Taxi Going to:" + location);
        }
    }
}