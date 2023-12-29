
using dioExemplo.Models;
using System.Globalization;
using System.IO; 

namespace dioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                {1, "MENU"},
                {2, "OPÇÕES"},
                {3, "CARDÁPIO"}
            };
            dict.Add(4,"SAIR");
            dict.Add(5,"TESTE");
            dict.Remove(5);
            dict[1] = "CONTATO";

            foreach (var item in dict){
                Console.WriteLine($"Chave: {item.Key} || Valor: {item.Value}");
            }

            int teste = 1;
            if (dict.ContainsKey(teste))
            {
                Console.WriteLine($"A chave {teste} já está cadastrada no sistema");
            }
            else {
                Console.WriteLine("A chave escolhida está disponivel");
            }
            

        }
    }
}
