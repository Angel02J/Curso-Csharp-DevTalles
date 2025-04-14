partial class Program
{
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;

        bool isGreaterThanTen = number > 10;

        if(isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número {number} es par y mayor que 10");
        }
        else if(!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número es {number} es impar y es mayor que 10");
        }
        else
        {
            Console.WriteLine($"El número {number} no cumple con las condiciones");
        }

        //Operador ternario (?:)
        int age = 21;
        string category = age > 18 ? "Adulto": "Menor";
        Console.WriteLine(category);
    }

}