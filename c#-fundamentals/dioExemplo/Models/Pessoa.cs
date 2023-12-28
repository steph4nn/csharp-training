using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dioExemplo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar(){
            Console.WriteLine($"O nome do cliente é {Nome} e tem {Idade} anos de idade");
        }

    }
}