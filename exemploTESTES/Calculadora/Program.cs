﻿namespace Calculadora;
using Calculadora.Services;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraImp c = new CalculadoraImp();

        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} + {num2} = {c.Somar(num1,num2)}");
    }
}
