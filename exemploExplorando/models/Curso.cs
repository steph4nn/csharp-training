using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemploExplorando.models;

namespace exemploExplorando.models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public int QuantidadeAlunos()
        {
            int total = Alunos.Count;
            return total;
        }
        public void ListarTodosAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}");
            Console.WriteLine();
            foreach(Pessoa aluno in Alunos){
                aluno.Apresentar();
                Console.WriteLine();
            }
            
        }

    }
}