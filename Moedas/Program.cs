using System.Globalization;

namespace Moedas;

class Program
{
    public static void Main(string[] args)
    {
        decimal valor = 10536.25M;
        Console.WriteLine(valor.ToString(
            "C",
            CultureInfo.CreateSpecificCulture("pt-BR"))
        );

        Console.Clear();

        Console.WriteLine(
            Math.Floor(valor)
        );
    }
}