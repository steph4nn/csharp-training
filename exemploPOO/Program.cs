using exemploPOO.Models;
namespace exemploPOO;

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno("Lauro", 20);
        Professor p1 = new Professor("Alex", 50);
        Pessoa pe1 = new Pessoa("Marrie", 3);

        a1.Apresentar();
        p1.Apresentar();
        pe1.Apresentar();
    }
}
