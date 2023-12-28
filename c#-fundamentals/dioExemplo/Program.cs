using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        double[] arrayPotencia = new double[10];

        Array.Resize(ref arrayPotencia, arrayPotencia.Length *2);     
        Console.WriteLine("Digite um número para verificar suas potencias: ");
        int.TryParse(Console.ReadLine(), out int num);
        for(int i = 0; i < arrayPotencia.Length; i++){
            arrayPotencia[i] = Math.Round(Math.Pow(num,i+1),2);
        }
        double[] novoArray = new double [arrayPotencia.Length];
        
        Array.Copy(arrayPotencia, novoArray, arrayPotencia.Length);
        
        foreach(double valor in novoArray ){
            Console.WriteLine($"{valor}");
        }

    }
}
