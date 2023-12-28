using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {

    Pessoa novoCliente = new();
    string escolha;
    bool boolMenu = true;

    while (boolMenu){

        Console.WriteLine("Digite a sua opção");
        Console.WriteLine("1 - Cadastrar novo Cliente:");
        Console.WriteLine("2 - Atualizar dados do Cliente");
        Console.WriteLine("3 - Buscar dados do Cliente");
        Console.WriteLine("4 - Excluir dados do Cliente");
        escolha = Console.ReadLine();

        switch(escolha){
            case "1":
                Console.WriteLine("Insira o nome do cliente: ");
                string nomeDoCliente = Console.ReadLine();
                Console.WriteLine("Insira a idade do cliente: ");
                int.TryParse(Console.ReadLine(), out int idadeDoCliente);
                
                novoCliente.Nome = nomeDoCliente;
                novoCliente.Idade = idadeDoCliente;
                novoCliente.Apresentar();
                break;
            case "2":
                Console.WriteLine("Qual dado você deseja alterar?");
                Console.WriteLine("1 - nome");
                Console.WriteLine("2 - idade");
                string dadoAlterar = Console.ReadLine();
                if (dadoAlterar == "1")
                {
                    Console.WriteLine("Digite o novo nome do cliente");
                    novoCliente.Nome = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite a nova idade do cliente");
                    int idade;
                    int.TryParse(Console.ReadLine(), out idade);
                    novoCliente.Idade = idade;
                }
                break;
            case "3":
                Console.WriteLine("Buscando dados do cliente");
                Thread.Sleep(2000);
                novoCliente.Apresentar();
                break;
            case "4":
                Console.WriteLine("Excluindo dados do cliente");
                Thread.Sleep(5000);
                Console.WriteLine("Os dados do cliente foram apagados com sucesso");
                break;
            default:
                boolMenu = false;
                break;

        }
    Console.WriteLine("Programa encerrado");


    }


    }
}
