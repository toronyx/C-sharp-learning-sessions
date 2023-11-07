namespace Remote_Control_Car_Racing.Vehicles
{
    internal class RemoteControlCar
    {
        private readonly float topSpeedMilesPerHour;
        private readonly float batteryDrainPercPerMile;
        private float batteryPercentage;
        private float distanceTravelledMiles;
        private string name = "car";

        public RemoteControlCar(float topSpeedMilesPerHour, float batteryDrainPercPerMile, string name)
        {
            #region Validation
            if (topSpeedMilesPerHour < 0) throw new ArgumentOutOfRangeException($"{nameof(topSpeedMilesPerHour)} must not be negative");
            if (batteryDrainPercPerMile < 0) throw new ArgumentOutOfRangeException($"{nameof(batteryDrainPercPerMile)} must not be negative");
            #endregion

            this.topSpeedMilesPerHour = topSpeedMilesPerHour;
            this.batteryDrainPercPerMile = batteryDrainPercPerMile;
            batteryPercentage = 100;
            distanceTravelledMiles = 0;
            this.name = name;
        }

        public string GetCarName()
        {
            return name;
        }

        public float MaximumRangeMiles() => batteryDrainPercPerMile / 100;

        public float RemainingRangeMiles() => batteryDrainPercPerMile / batteryPercentage;

        public float Drive(TimeSpan duration)
        {
            if (batteryPercentage <= 0) return 0;

            var distanceTravelled = MathF.Min(topSpeedMilesPerHour * (float)duration.TotalHours, RemainingRangeMiles());
            distanceTravelledMiles += distanceTravelled;
            batteryPercentage -= batteryDrainPercPerMile * distanceTravelled;
            return distanceTravelled;
        }


    }
}
