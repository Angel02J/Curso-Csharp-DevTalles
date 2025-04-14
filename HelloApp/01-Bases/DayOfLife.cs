partial class Program
{
    static void DayOfLife1()
    {
        DateTime birthDay = new DateTime(2002, 3, 17);
        TimeSpan difference = DateTime.Now - birthDay;

        Console.WriteLine($"Has vivido {difference.Days} dias");
    }
}