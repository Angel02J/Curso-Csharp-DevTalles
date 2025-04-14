partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine($"X:{x}, Y:{y}");

        Person person1 = new Person{Name = "Carlos"};
        Person person2 = person1;
        person2.Name = "Alicia";

        Console.WriteLine($"Person 1:{person1.Name}");   
    }    
}

class Person{
    public string? Name { get; set; }
}