partial class Program
{
    static void DataStructures()
    {
        User pedro = new User { Name = "Pedro", Age = 23 };
        pedro.Greet();

        Point punto = new Point{X = 30 , Y = 30};

        Console.WriteLine($"Punto({punto.X}), {punto.Y}");

        CellPhone celular = new CellPhone("Samsung", 2022);
        System.Console.WriteLine(celular);
    }
}

class User
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age}");
    }
}

struct Point 
{
    public int X { get; set; }

    public int Y { get; set; }
}

record CellPhone(string Model, int Year);