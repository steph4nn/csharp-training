using exemploExplorando.models;
namespace exemploExplorando;


class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("lauro", "stephan");
        p1.Idade = 21;
        Pessoa p2 = new Pessoa("leticia", "stephan");
        p2.Idade = 21;
        

        Curso cursoDeIngles = new Curso();
        cursoDeIngles.Nome = "Wizard";
        cursoDeIngles.Alunos = new List<Pessoa>();

        cursoDeIngles.AdicionarAluno(p1);
        cursoDeIngles.AdicionarAluno(p2);

        cursoDeIngles.ListarTodosAlunos();

    }
}
