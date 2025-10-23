public struct Time
{
    public int minutes;

    public Time(int hours, int mins)
    {
        minutes = hours * 60 + mins;
    }

    public override string ToString() => $"{minutes} minutes";
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(9, 30); // 9*60 + 30 = 570
        Time t2 = t1;               // Copy t1 into t2
        t1.minutes = 100;           // Change t1’s minutes

        Console.WriteLine($"t1 = {t1} and t2 = {t2}");
        Console.WriteLine("A struct stores a copy of data,\r\na class stores a reference to data." +
            "\r\n\r\nSo changing one struct variable doesn’t affect the other,\r\nbut changing" +
            " one class variable does — because both point to the same object.");
    }
}
