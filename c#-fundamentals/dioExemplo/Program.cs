using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número: ");
        int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine("--------PROCESSANDO OS DADOS-------------");
        Thread.Sleep(2000);
        Calculadora calc = new Calculadora();
        for (int i = 1; i <=10 ; i++){
            calc.Multiplicar(num, i);
            Thread.Sleep(500);
        }
    }
}