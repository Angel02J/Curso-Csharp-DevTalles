partial class Program
{
    static void InventoryManagerSolution2()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        Console.WriteLine("1.Comprar producto");
        Console.WriteLine("2.Salir");
        Console.WriteLine("Ingrese la opción");
        int option = int.Parse(Console.ReadLine()!);

        if(option == 1)
        {
            Console.WriteLine("Inventario de productos");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
            }

            Console.WriteLine("\n Ingrese el producto que desea comprar");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad que desea comprar");
            int quantity = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < products.Length; i++)
            {
                if(products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase)) 
                {
                    if(quantity <= stock[i])
                    {
                        double total = quantity * prices[i];
                        stock[i] -= quantity;
                        Console.WriteLine($"Compra exitosa. El total a pagar: {total:C}");
                        Console.WriteLine($"Stock restante para el producto: {searchedProduct} es {stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine("No hay sufuciente stock disponible");
                    }
                }
            }
        }
        else if(option == 2)
        {
            Console.WriteLine("Gracias por su visita");
        }
        else
        {
            Console.WriteLine("Opción invalida");
        }
    }
}