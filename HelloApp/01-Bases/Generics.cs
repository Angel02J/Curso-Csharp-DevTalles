partial class Program
{
    static void Generics()
    {
        string[] names = {"Juan", "Luis","Diana"};
        int[] numbers = {1, 2, 3,};

        System.Console.WriteLine($"Tamaño del arreglo númerico {GetInArrayLength(numbers)}");
        System.Console.WriteLine($"Tamaño del arreglo nombres {GetStringArrayLength(names)}");
        System.Console.WriteLine($"Tamaño del arreglo nombres {GetArrayLength(names)}");
    }

    static int GetInArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Metodo genérico
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}