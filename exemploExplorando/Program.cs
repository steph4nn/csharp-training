using exemploExplorando.models;
namespace exemploExplorando;


class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "lauro";
        p1.Idade = 21;
        p1.Apresentar();
    }
}
