namespace SmartHomeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();

            Light light = new Light() { Name = "Лампа у вітальні" };
            AirConditioner conditioner = new AirConditioner() { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffeeMachine = new CoffeeMachine() { Name = "Кавомашина на кухні" };
            MotionSensor motionSensor = new MotionSensor() { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(conditioner);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(motionSensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(conditioner);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOn();

            light.PrintStatus();
            conditioner.PrintStatus();
            coffeeMachine.PrintStatus();
            motionSensor.PrintStatus();

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();
        }
    }
}
