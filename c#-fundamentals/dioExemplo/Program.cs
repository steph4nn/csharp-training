using dioExemplo.Models;
using System.Globalization;
namespace dioExemplo;

class Program
{
    static void Main(string[] args)
    {
        string dataString = "07/06/02";
        bool verificacaoData = DateTime.TryParseExact(dataString,"dd/MM/yy",CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data);

        if(verificacaoData){
            Console.WriteLine(data);
        }


    }
}
