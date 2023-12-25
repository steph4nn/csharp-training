using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        p.Idade = 20;
        p.Nome = "Lauro";
        p.Apresentar();
        
    }
}
