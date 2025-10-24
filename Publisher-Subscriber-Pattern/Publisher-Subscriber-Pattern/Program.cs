using System;

namespace EventExample
{

    // Step 1: Declare delegate
    public delegate void SpeedExceededHandler(int speed);

    // Step 2: Publisher class
    class Car
    {
        public event SpeedExceededHandler OnSpeedExceeded;
        private int speed;

        public void Accelerate(int increaseBy)
        {
            speed += increaseBy;
            Console.WriteLine($"Current speed: {speed} km/h");

            // Check for overspeed
            if (speed > 100)
            {
                OnSpeedExceeded?.Invoke(speed);
            }
        }
    }

    // Step 3: Subscribers
    class Police
    {
        public static void RecordSpeed(int speed)
        {
            Console.WriteLine($"[Police] Speed recorded: {speed} km/h");
        }
    }

    class DriverAlert
    {
        public static void ShowWarning(int speed)
        {
            Console.WriteLine($"[Driver Alert] Warning! You are overspeeding at {speed} km/h!");
        }
    }

    // Step 4: Program (Wiring up everything)
    class Program
    {
        static void Main()
        {
            Car car = new Car();

            // Subscribe methods to event
            car.OnSpeedExceeded += Police.RecordSpeed;
            car.OnSpeedExceeded += DriverAlert.ShowWarning;

            // Simulate driving
            car.Accelerate(30);
            car.Accelerate(40);
            car.Accelerate(50);  // This will cross 100 → event triggers
        }
    }
}
