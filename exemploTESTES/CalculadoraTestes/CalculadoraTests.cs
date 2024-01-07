namespace CalculadoraTestes;
using Calculadora.Services;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }
    
    [Fact]
    public void DeveSomarCincoComDezEhRetornar15()
    {
        //arrange
        int num1=5;
        int num2 =10;

        //act
        int resultado = _calc.Somar(num1,num2);

        //assert
        Assert.Equal(15,resultado);


    }
     public void DeveSomarDezCom20EhRetornar30()
    {
        //arrange
        int num1=10;
        int num2 =20;

        //act
        int resultado = _calc.Somar(num1,num2);

        //assert
        Assert.Equal(30,resultado);


    }
}