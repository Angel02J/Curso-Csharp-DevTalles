partial class Program
{
    static void Loops()
    {
        //While
        int counter = 1;

        while(counter <= 5)
        {
            WriteLine($"Iteración {counter}");
            counter++;
        }

        //do while
        int number = 0;
        do
        {
            WriteLine($"Número: {number}");
            counter++;
        }
        while(number < 3);
    }
}