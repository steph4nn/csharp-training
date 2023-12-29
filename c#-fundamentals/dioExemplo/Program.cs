
using dioExemplo.Models;
using System.Globalization;
using System.IO; 

namespace dioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);
            fila.Dequeue();
            fila.Enqueue(10);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---------ELEMENTOS DA FILA-----------");
            Console.WriteLine("-------------------------------------");
            foreach (int num in fila){
                Console.WriteLine(num);
            }

            Stack<int> pilha = new Stack<int>();
            pilha.Push(2);
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Pop();
            pilha.Push(10);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---------ELEMENTOS DA PILHA-----------");
            Console.WriteLine("-------------------------------------");
            foreach (int num in pilha){
                Console.WriteLine(num);
            }

        }
    }
}
