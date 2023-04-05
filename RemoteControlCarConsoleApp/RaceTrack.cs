using Remote_Control_Car_Racing.Vehicles;

namespace Remote_Control_Car_Racing.RaceTracks
{
    internal class RaceTrack
    {
        private readonly float distanceMiles;

        private List<RemoteControlCar> carsOnTrack = new();

        RemoteControlCar nitroCar = new RemoteControlCar(50f, 0.2f, "nitro car");


        public RaceTrack(float distanceMiles)
        {
            this.distanceMiles = distanceMiles;
            this.carsOnTrack.Add(nitroCar);
        }

        public bool CanFinishRace(RemoteControlCar car) => car.RemainingRangeMiles() >= distanceMiles;

        public void CheckEachCar()
        {
            foreach (RemoteControlCar car in carsOnTrack)
            {

                if (CanFinishRace(car))
                {
                    Console.WriteLine("{0}", car.GetCarName());
                }
            }
        }
    }

}
