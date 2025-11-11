namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;
        protected double fuelMax = 50;
        protected double fuelLevel;

        public Car(string brand, int year, double mileage, int doors) : base(brand, year, mileage, 180.0)
        {
            this.doors = doors;
            fuelLevel = fuelMax;
        }

        public Car(string brand, int year, double mileage, int doors, double maxSpeed) : base(brand, year, mileage, maxSpeed)
        {
            this.doors = doors;
            fuelLevel = fuelMax;
        }

        public override string GetInfo()
        {
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel}L";
        }

        public override void Move(double distance)
        {
            if (fuelLevel > 0)
            {
                base.Move(distance);

                fuelLevel -= distance * 0.1;
            }

            if (fuelLevel  < 0)
            {
                fuelLevel = 0;
            }
        }

        public void Refuel(double liters)
        {
            if (fuelLevel < fuelMax)
            {
                fuelLevel += liters;

                if (fuelLevel > fuelMax)
                    fuelLevel = fuelMax;

                Console.WriteLine($"The car is fueled up to {fuelLevel} liters.");
            }
            else
            {
                Console.WriteLine("The fuel tank of the tank is full");
            }
        }

    }
}
