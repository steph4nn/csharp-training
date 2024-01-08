using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Microsoft.VisualBasic;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesStrings _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesStrings();  
        }

        [Theory]
        [InlineData(new string[]{"Olá","Marrie","Lauro"},new int[]{3,6,5})]

        public void DeveContarOsCaracteresERetornarValorCerto(string[] input, int[] valorEsperado)
        {
            // ASSERT
            for (int i = 0; i < input.Length; i++)
            {
                int resultado = _validacoes.ContarCaract(input[i]);
                Assert.Equal(valorEsperado[i], resultado);
            }
        }
    }
}