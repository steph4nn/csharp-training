using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {

        Calculadora calc = new Calculadora();
        calc.Somar(7, 6);
        calc.Subtrair(7, 6);
        calc.Multiplicar(7, 6);
        calc.Dividir(7, 6);
        calc.Potencia(7, 6);
        calc.Seno(90);
        calc.Coseno(90);
        calc.Tangente(90);
    }
}