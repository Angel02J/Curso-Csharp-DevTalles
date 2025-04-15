partial class Program
{
    static void Calculadora()
    {
        WriteLine("Elige una opción");
        WriteLine("----------------");
        WriteLine("1. Suma");
        WriteLine("2. Resta");
        WriteLine("3. División");
        WriteLine("4. Multiplicación");

        WriteLine("Ingresa el número de la opcion a elegir");
        int option = int.Parse(ReadLine()!);

        switch (option)
        {
            case 1:
                WriteLine("Suma");

                WriteLine("Ingrese el primero número");
                int numer1Suma = int.Parse(ReadLine()!);

                WriteLine("Ingrese el segundo número");
                int number2Suma = int.Parse(ReadLine()!);

                int resultSuma = numer1Suma + number2Suma;

                WriteLine($"Resultado: {resultSuma}");
            break;

            case 2:
                WriteLine("Resta");

                WriteLine("Ingrese el primero número");
                int numer1Resta = int.Parse(ReadLine()!);

                WriteLine("Ingrese el segundo número");
                int number2Resta = int.Parse(ReadLine()!);

                int resultResta = numer1Resta - number2Resta;

                WriteLine($"El resultado es: {resultResta}");

            break;

            case 3:
                WriteLine("División");

                WriteLine("Ingrese el primer número");
                int number1Div = int.Parse(ReadLine()!);

                WriteLine("Ingrese el segundo número");
                int number2Div = int.Parse(ReadLine()!);

                int resultDiv = number1Div / number2Div;

                WriteLine($"El resultado es: {resultDiv}");

            break;

            case 4: 
                WriteLine("Multiplicación");

                WriteLine("Ingrese el primer número");
                int number1Mult = int.Parse(ReadLine()!);

                WriteLine("Ingrese el segundo número");
                int number2Mult = int.Parse(ReadLine()!); 

                int resultMult = number1Mult * number2Mult;

                WriteLine($"El resultado es: {resultMult}");
                
            break;

            default:
                WriteLine("Opción no valida");
            break;
        }
    }
}