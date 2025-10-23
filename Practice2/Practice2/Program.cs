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
        public int Hour
        {
            get { return minutes / 60; }
        }

        public int Minute
        {
            get { return minutes % 60; }
        }

        public override string ToString()
        {
            return String.Format("{0:D2}:{1:D2}", Hour, Minute);
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
            Console.WriteLine(morning.Hour);
            Console.WriteLine(morning.Minute);
           
        }
    }
}