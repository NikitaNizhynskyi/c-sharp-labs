namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer
    {
        public string DeviceName => Name;

        public int PowerConsumption => 2000;
        public override void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Console.WriteLine($"{Name} почав охолодження.");
            }
        }

        public override void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine($"{Name} зупинено.");
            }
        }

        public double GetEnergyUsage(int hours)
        {
            double energy = 0;
            if (!IsOn)
            {
                return 0;
            }
            return energy = (PowerConsumption * hours) / 1000.0;
        }
    }
}
