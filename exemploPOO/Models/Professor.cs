using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public sealed class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public Professor(string nome, int idade) : base(nome,idade)
        {
            
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario:C}");
        }
    }
}