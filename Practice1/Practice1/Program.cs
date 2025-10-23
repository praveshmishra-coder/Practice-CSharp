using System;

namespace TestTime
{
    public struct Time
    {
        private readonly int minutes;

        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }

        public override string ToString()
        {
            return minutes.ToString();
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Time morning = new Time(10, 5);
            Time Evening = new Time(0, 45);
            Console.WriteLine(morning);
            Console.WriteLine(Evening);
        }
    }
}