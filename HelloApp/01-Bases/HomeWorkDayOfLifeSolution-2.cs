using System.Globalization;

partial class Program
{
    static void DayOfLife3()
    {
        // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
        // Consideraciones:
        // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
        //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
        // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
        // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
        //   sumando un año para calcular la fecha del próximo (opcional).

        Console.WriteLine("Introduce tu fecha de nacimiento (dd/MM/yyyy)");
        string birthDateString = Console.ReadLine()!;

        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime currentDate = DateTime.Now.Date;

        DateTime nextBirthDay = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextBirthDay < currentDate)
        {
            nextBirthDay = nextBirthDay.AddYears(1);
        }

        int dayRemaining = (nextBirthDay - currentDate).Days;

        System.Console.WriteLine($"Faltan {dayRemaining} dias para tu proximo cumpleaños");
    }
}