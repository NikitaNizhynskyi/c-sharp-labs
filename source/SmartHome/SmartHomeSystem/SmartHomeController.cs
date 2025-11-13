using System.Text.RegularExpressions;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        public List<ISwitchable> deviceList { get; set; } = new List<ISwitchable>();

        public List<IEnergyConsumer> energyDeviceList { get; set; } = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            deviceList.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDeviceList.Add(device);
        }

        public void TurnAllOn()
        {
            foreach(var device in deviceList)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (var device in deviceList)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");

            double totalEnergy = 0;

            foreach (var consumer in energyDeviceList)
            {
                double energyUsed = consumer.GetEnergyUsage(hours);
                totalEnergy += energyUsed;

                Console.WriteLine($"{consumer.DeviceName}: {energyUsed:F2} кВт·год (потужність: {consumer.PowerConsumption} Вт)");
            }

            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            double cost = totalEnergy * 4.0;
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {cost:F2} грн");
        }
    }
}
