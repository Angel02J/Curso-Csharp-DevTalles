partial class Program
{
    static void NumericTypes()
    {
        int integerNumber = 42;
        double decimalNumber = 3.1416d;
        float floatingNumber = 2.61f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;

        Console.WriteLine($"Entero: {integerNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");
        Console.WriteLine($"Flotante: {floatingNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Decimal: {monetaryNumber}");
    }
}