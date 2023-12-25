namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static float Soma(float x, float y){
        return x+y;
    }
    static float Subtracao(float x, float y){
        return x-y;
    }
    static float Multiplicacao(float x, float y){
        return x*y;
    }
    static float Divisao(float x, float y){
        return x/y;
    }
    static void Menu(){
        Console.Write(@"Qual operação deseja realizar: 
            
        1 - Adição
        2 - Subtração
        3 - Multiplicação
        4 - Divisão
        
        Digite sua opção: ");
        int x = int.Parse(Console.ReadLine());

    }
}
