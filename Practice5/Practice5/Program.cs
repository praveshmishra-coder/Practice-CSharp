internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("You can’t have a non-static field" +
            " of the same type inside a struct because that would make it" +
            " infinitely large,\r\nbut it’s fine in a class because it just stores " +
            "a reference.\r\n\r\nYou can have a static field (like noon) in a struct" +
            " because static fields belong to the type, not to each object.");
    }
}