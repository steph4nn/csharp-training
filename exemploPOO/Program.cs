using exemploPOO.Interfaces;
using exemploPOO.Models;
namespace exemploPOO;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        ICalculadora calcI = new Calculadora();
    }
}
