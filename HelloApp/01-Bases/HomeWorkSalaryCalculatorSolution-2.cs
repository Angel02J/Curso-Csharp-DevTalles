
partial class Program
{
    static void HomeWorkSolution2()
    {
        Console.WriteLine("Calculadora de salario");

        Console.WriteLine();

        Console.Write("Ingrese su nombre: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Ingrese el número de horas trabajadas: ");
        double hours = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese el salario por hora: ");
        double hoursRate = double.Parse(Console.ReadLine()!);

        double salary = hours * hoursRate;

        Console.WriteLine($"El salario para {name} es de {salary}");
    }
}