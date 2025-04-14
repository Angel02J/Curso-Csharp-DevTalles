partial class Program
{
    static void InventoryManagerSolution1()
    {
        string[] menu = ["Comprar producto", "Salir"];
        int[] optionsMenu = [1, 2];
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        for(int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"{optionsMenu[i]}. {menu[i]}");
            Console.WriteLine("Ingrese una opción");
            int chosedOption = int.Parse(Console.ReadLine()!);
            if(chosedOption > optionsMenu[i])
            {
                Console.WriteLine("Gracias por su visita");
                Environment.Exit(0);
            }
        }

        Console.WriteLine("Inventario de productos");
        Console.WriteLine("-----------------------");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}");
        }

        Console.WriteLine("\n Ingrese el producto que desea comprar");
        string? searchedProduct = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad que desea comprar");
        int quantity = int.Parse(Console.ReadLine()!);

        for(int i = 0; i < products.Length; i++)
        {
            if(products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase)) //Compara lo que ingreso el usuario con el lo que hay en el arreglo
            {
                if(quantity <= stock[i]) //Si la cantidad que ingreso el usuario es menor o igual al limite del stock del producto, se cumple la condicion
                {
                    double total = quantity * prices[i];
                    Console.WriteLine($"Compra exitosa. El total a pagar: {total}");
                }
                else
                {
                    Console.WriteLine("No hay sufuciente stock disponible");
                }
            }
        }
    }
}