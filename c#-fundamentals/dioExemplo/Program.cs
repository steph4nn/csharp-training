using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        string frase = "Frase de teste";
        int inteiro = 777;
        double desconsideraZero = 1.90;
        decimal usadoParaDinheiro = 2.6M;
        float lembrarDoEfiNoFinal =  2.55F;
        bool booleano = true;


        Console.WriteLine($"Valor da váriavel: {frase}");
        Console.WriteLine($"Valor da váriavel: {inteiro}");
        Console.WriteLine($"Valor da váriavel: {desconsideraZero}");
        Console.WriteLine($"Valor da váriavel: {usadoParaDinheiro}");
        Console.WriteLine($"Valor da váriavel: {lembrarDoEfiNoFinal}");
        Console.WriteLine($"Valor da váriavel: {booleano}");

        
    }
}
