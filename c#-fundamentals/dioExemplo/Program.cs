using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        List<string> listString = new List<string>();
        listString.Add("Lauro");
        Console.WriteLine(listString.Capacity);
        listString.Add("Leticia");
        listString.Add("Marrie");
        Console.WriteLine(listString.Capacity);
        listString.Add("Ravi");
        Console.WriteLine(listString.Capacity);
        listString.Add("Lorenzo");
        Console.WriteLine(listString.Capacity);
    }
}
