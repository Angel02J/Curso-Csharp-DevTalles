partial class Program
{
    static void HomeWork()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad vendida: {quantitySold}");
        Console.WriteLine($"Total generado: {totalAmount:C}");
    }
}