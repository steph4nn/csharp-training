﻿using dioExemplo.Models;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {



        string a = "15";
        int b = 5;


        // Caso o TryParse não seja bem sucedido permanece o valor original/nulo caso a variavel a esteja sendo inicializada
        int.TryParse(a, out b);
        int.TryParse(a, out int c); 

        Console.WriteLine(b);
        Console.WriteLine(c);



        // int inteiro = 5;
        // string teste = inteiro.ToString();


        // int a = Convert.ToInt32("5"); // convert aceita nulos
        // int b = int.Parse("7"); //parse não aceita nulos
        
        // Console.WriteLine(a);
        // Console.WriteLine(b);





        // DateTime dataAtual= DateTime.Now.AddDays(5);
        // Console.WriteLine(dataAtual.ToString("MM/dd/yy"));
        // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        // Console.WriteLine(dataAtual.ToString("HH:mm"));












        // string frase = "Frase de teste";
        // int inteiro = 777;
        // double desconsideraZero = 1.90;
        // decimal usadoParaDinheiro = 2.6M;
        // float lembrarDoEfiNoFinal =  2.55F;
        // bool booleano = true;


        // Console.WriteLine($"Valor da váriavel: {frase}");
        // Console.WriteLine($"Valor da váriavel: {inteiro}");
        // Console.WriteLine($"Valor da váriavel: {desconsideraZero}");
        // Console.WriteLine($"Valor da váriavel: {usadoParaDinheiro}");
        // Console.WriteLine($"Valor da váriavel: {lembrarDoEfiNoFinal}");
        // Console.WriteLine($"Valor da váriavel: {booleano}");

        
    }
}