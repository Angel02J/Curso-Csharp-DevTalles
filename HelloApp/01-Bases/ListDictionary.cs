partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string>{"Ana", "Carlos", "Juan"};
        names.Add("Lucia");

        Console.WriteLine($"Total de nombres: {names.Count}");

        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"¿Ana esta en la lista? {isPresent}");

        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        Console.WriteLine($"El estudiante con ID es: {students[1]}");
        foreach(var student in students)
        {
            Console.WriteLine($"Id: {student.Key}, Nombre: {student.Value}");
        }
    }
}