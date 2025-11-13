namespace SmartHomeSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public string DeviceName => Name;

        public int PowerConsumption => 60;

        public override void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Console.WriteLine($"{Name} засвітилася.");
            }
        }

        public override void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine($"{Name} вимкнена.");
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
