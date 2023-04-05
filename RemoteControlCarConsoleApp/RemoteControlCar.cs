namespace RemoteControlCar
{
    public class RemoteControlCar
    {
        private float speed;
        private float batteryDrainRate;
        private float batteryPercentage;

        public RemoteControlCar(float speed, float batteryDrain) 
        {
            this.speed = speed;
            this.batteryDrainRate = batteryDrain;
            this.batteryPercentage = 1f;
        }

        public void DrainBattery()
        {
            batteryPercentage -= batteryDrainRate;
            if (batteryPercentage < 0f)
            {
                batteryPercentage = 0f;
            }
        }
    }
}