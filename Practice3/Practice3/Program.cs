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

        public Time(int minutes)
        {
            this.minutes= minutes;
        }
        public int Hour
        {
            get { return minutes / 60; }
        }

        public int Minute
        {
            get { return minutes % 60; }
        }
        //Overload + operator
        public static Time operator +(Time t1,Time t2)
        {
            return new Time(t1.minutes + t2.minutes);
        }

        //Overload - operator
        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.minutes - t2.minutes);
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
            Time t1 = new Time(10, 5);
            Time t2 = new Time(0, 45);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine("t1+t2:"+(t1+t2));
            Console.WriteLine("t1-t2:"+(t1-t2));

            

        }
    }
}