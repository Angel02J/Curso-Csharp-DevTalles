using System.Globalization;

partial class Program
{
    static void DayOfLife2()
    {
        // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
        // Consideraciones:
        // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
        //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
        // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
        // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
        //   sumando un año para calcular la fecha del próximo (opcional).

        DateTime birthDay;
        DateTime getYear = DateTime.Today;
        int year = getYear.Year;

        Console.WriteLine("Ingresa tu fecha de nacimiento: (dd/MM/yyyy)  ");
        birthDay = DateTime.Parse(Console.ReadLine()!);

        DateTime nextBirthDay = new DateTime(year, birthDay.Month, birthDay.Day);

        if (nextBirthDay >= birthDay)
        {
            nextBirthDay = nextBirthDay.AddYears(1);
            Console.WriteLine($"Tu proximo cumpleaños es el :{nextBirthDay.ToShortDateString()} ");
        }
    }
}