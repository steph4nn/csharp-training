using exemploPOO.Models;
namespace exemploPOO;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente c1 = new ContaCorrente(123,2000);
        c1.ExibirSaldo();
        c1.Sacar(500M);
        c1.ExibirSaldo();
        c1.Sacar(2000);
        c1.ExibirSaldo();
    }
}
