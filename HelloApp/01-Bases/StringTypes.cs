partial class Program
{
    static void StringTypes()
    {
        string name = "Juan";
        string message = "Hola" + name;
        string interpolatedMessage = $"Hola{name}";
        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);

        Console.WriteLine($"Tu nombre tiene: {name.Length} palabras");
        Console.WriteLine($"Tu nombre en mayusculas: {name.ToUpper()}");

        int number = 13;
        Console.WriteLine(number);
        bool isString = true;
        Console.WriteLine(isString);
    }
}