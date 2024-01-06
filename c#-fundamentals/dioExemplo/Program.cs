
using dioExemplo.Models;
using System.Globalization;
using System.IO; 

namespace dioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double quilometrosPorDia = double.Parse(Console.ReadLine());
            int horasDeEletronicos = int.Parse(Console.ReadLine());
            int refeicoesComCarne = int.Parse(Console.ReadLine());
            double carbono = CalcularCarbono(quilometrosPorDia,horasDeEletronicos,refeicoesComCarne);

            Console.WriteLine($"{nome}, sua pegada de carbono e de {carbono} toneladas de CO2 por ano.");

        }
        static double CalcularCarbono(double km, int hrs, int refeicoes){
            double carbono;
            km = km*365*0.2;
            double horas = Convert.ToDouble(hrs);
            horas = horas*0.1;
            double ref1 = Convert.ToDouble(refeicoes);
            ref1 = ref1*0.5;
            carbono = km +horas +ref1;
            return carbono;
        }
    }
}
