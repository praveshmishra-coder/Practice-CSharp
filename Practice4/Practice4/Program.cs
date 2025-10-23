using System;

namespace TestTime
{
    public struct Time
    {
        private readonly int minutes;

        // Constructor (hours, minutes)
        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }

        // Constructor (total minutes)
        public Time(int minutes)
        {
            this.minutes = minutes;
        }

        // Read-only properties
        public int Hour => minutes / 60;
        public int Minute => minutes % 60;

        // Operator overloading (+ and -)
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.minutes + t2.minutes);
        }

        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.minutes - t2.minutes);
        }

        // Add operator overload for Time + int
        public static Time operator +(Time t, int m)
        {
            return new Time(t.minutes + m);
        }

        // Implicit conversion from int to Time
        public static implicit operator Time(int minutes)
        {
            return new Time(minutes);
        }

        // Explicit conversion from Time to int
        public static explicit operator int(Time t)
        {
            return t.minutes;
        }

        // String representation
        public override string ToString()
        {
            return String.Format("{0:D2}:{1:D2}", Hour, Minute);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Time t1 = new Time(9, 30);   // 9:30 AM
            Time t2 = 120;               // implicit conversion: 120 min = 2:00 AM
            int m1 = (int)t1;            // explicit conversion: Time → int (minutes)

            Console.WriteLine("t1={0} and t2={1} and m1={2}", t1, t2, m1);

            Time t3 = t1 + 45;           // add 45 minutes to t1 (legal because of implicit conversion)
            Console.WriteLine("t3 = " + t3);
        }
    }
}
