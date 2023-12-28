using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        double[] arrayPotencia = new double[10];
        Console.WriteLine("Digite um número para verificar suas potencias: ");
        int.TryParse(Console.ReadLine(), out int num);
        for(int i = 0; i < arrayPotencia.Length; i++){
            arrayPotencia[i] = Math.Round(Math.Pow(num,i+1),2);
        }
        foreach(double valor in arrayPotencia ){
            Console.WriteLine($"{valor}");
        }

    }
}
