using dioExemplo.Models;
using System.Globalization;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        decimal numeroTeste = .2795M;

        Console.WriteLine(numeroTeste.ToString("P"));
        Console.WriteLine(numeroTeste.ToString(".##-##"));

        DateTime data = DateTime.Now;
        Console.WriteLine(data.ToString("yy-MM-dd"));

    }
}
