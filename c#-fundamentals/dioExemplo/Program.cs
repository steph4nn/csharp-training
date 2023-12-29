using dioExemplo.Models;
using System.Globalization;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");


        Console.WriteLine("Qual o seu salário? ");
        decimal.TryParse(Console.ReadLine(), out decimal salario);
        decimal valorMonetario = salario;
        Console.WriteLine ($"Seu salário, em dolares, é de: {valorMonetario:C}");
        Console.WriteLine($"Seu salário ,em Reais, é de: {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        Console.WriteLine($"Seu salário ,em Yens, é de: {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))}");

    }
}
