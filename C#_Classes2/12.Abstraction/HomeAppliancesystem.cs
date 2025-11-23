using System;

namespace HomeApplianceSystem
{
    // Abstract parent class
    abstract class Appliance
    {
        public string Brand { get; set; }
        public int PowerUsageWatts { get; set; }

        // Abstract methods (rules)
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void ShowMode();

        // Concrete method
        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Power Usage: {PowerUsageWatts}W");
        }
    }

    // Child class 1
    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Machine is now ON.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Washing Machine is now OFF.");
        }

        public override void ShowMode()
        {
            Console.WriteLine("Current Mode: Quick Wash.");
        }
    }

    // Child class 2
    class Refrigerator : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Refrigerator is now cooling.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Refrigerator is turned OFF.");
        }

        public override void ShowMode()
        {
            Console.WriteLine("Cooling Mode: Eco Mode.");
        }
    }

    class Program
    {
        static void Main()
        {
            Appliance wm = new WashingMachine()
            {
                Brand = "LG",
                PowerUsageWatts = 1500
            };

            wm.TurnOn();
            wm.ShowMode();
            wm.ShowDetails();
            wm.TurnOff();

            Console.WriteLine();

            Appliance fridge = new Refrigerator()
            {
                Brand = "Samsung",
                PowerUsageWatts = 200
            };

            fridge.TurnOn();
            fridge.ShowMode();
            fridge.ShowDetails();
            fridge.TurnOff();
        }
    }
}
