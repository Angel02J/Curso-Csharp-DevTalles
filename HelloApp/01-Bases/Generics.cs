partial class Program
{
    static void Generics()
    {
        string[] names = {"Juan", "Luis","Diana"};
        int[] numbers = {1, 2, 3,};

        System.Console.WriteLine($"Tamaño del arreglo númerico {GetInArrayLength(numbers)}");
        System.Console.WriteLine($"Tamaño del arreglo nombres {GetStringArrayLength(names)}");
        System.Console.WriteLine($"Tamaño del arreglo nombres {GetArrayLength(names)}");

        Box<int> numberBox = new Box<int>{ Content = 50};
        Box<string> stringBox = new Box<string>{ Content = "Ahora soy un string"};
        numberBox.Show();
        stringBox.Show();
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

    class Box<T>
    {
        public T? Content { get; set; }

        public void Show()
        {
            System.Console.WriteLine($"Contenido: {Content}");
        }
    }
}