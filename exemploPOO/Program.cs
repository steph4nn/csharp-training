using exemploPOO.Models;
namespace exemploPOO;

class Program
{
    static void Main(string[] args)
    {
        Corrente c = new Corrente();
        c.Creditar(500);
        c.ExibirSaldo();
    }
}
