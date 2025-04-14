partial class Program
{
    static void SalaryCalculator()
    {
        string name;
        int hoursWorked;
        int hourRate = 10;

        Console.WriteLine("----- Calculadora de salario -----");

        Console.WriteLine("Ingrese su nombre:");
        name = Console.ReadLine()!;

        Console.WriteLine("Ingrese el número de horas trabajadas:");
        hoursWorked = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"El salario total es de: {hoursWorked * hourRate}");


    }
}