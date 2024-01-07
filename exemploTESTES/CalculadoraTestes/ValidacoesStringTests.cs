using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesStrings _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesStrings();  
        }

        [Fact]
        public void DeveContar3CaractEmOlarERetornar3()
        {
            //ARRANGE
            string texto = "Olá";

            //Act
            int resultado = _validacoes.ContarCaract(texto);

            //ASSERT
            Assert.Equal(3,resultado);

        }
    }
}