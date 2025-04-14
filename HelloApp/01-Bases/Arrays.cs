partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        //Directa
        int[] numbersArray = {5, 10, 15, 20, 25, 30};

        //Indices
        Console.WriteLine($"Primero elemento: {numbersArray[0]}");
        Console.WriteLine($"Tercer elemento: {numbersArray[2]}");

        //Tamaño arreglo
        Console.WriteLine($"El número de elementos es: {numbersArray.Length}");

        //Desde el final del arreglo
        Console.WriteLine($"Último elemento: {numbersArray[^1]}");

        //Penultimo
        Console.WriteLine($"Penultimo elemento: {numbersArray[^2]}");

        //Rangos para obtener subarreglos...
        int[] firstThree = numbersArray[..3]; //Muestra los primeros 3 elementos
        int[] fromIndexTwo = numbersArray[2..]; //Comienza desde el segundo

        foreach(var number in firstThree)
        {            
            Console.WriteLine(number);
        }

        foreach(var number in fromIndexTwo)
        {
            Console.WriteLine(number);
        }
    }
}