
using dioExemplo.Models;
using System.Globalization;
using System.IO; 

namespace dioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                string[] conteudoLinha = File.ReadAllLines(@"Arquivo/arq_Text.txt"); // Replace the incorrect escape character with @

                foreach (string linha in conteudoLinha)
                {
                    Console.WriteLine(linha);
                }
            }
            
            catch(FileNotFoundException ex){
                Console.WriteLine($"O arquivo não foi encontrada. {ex.Message}");
            }
            catch(DirectoryNotFoundException ex){
                Console.WriteLine($"A pasta não foi encontrada. {ex.Message}");
            }
            catch(Exception ex){
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            finally {
                Console.WriteLine("Passou por todas as exceções.");
            }
        }
    }
}
