using System.Text;

namespace MyApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        // GUID
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("GUID");
        Console.WriteLine();
        var id = Guid.NewGuid();
        id.ToString();

        // id = new Guid("8a12f972-ac33-48eb-8a9b-33353083392e"); // Can pass string uuid
        id = new Guid(); // All caracteres with 0
        Console.WriteLine(id);
        Console.WriteLine();

        // interpolation of string
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("interpolation of string");
        Console.WriteLine();
        var price = 10.2;
        // var texto = "O preço do produto é: " + price;
        // var texto = string.Format("O preço do produto é: {0}, apenas na promoção {1}", price, true);
        // var texto = $"O preço do produto é {price}, apenas na promoção";
        var texto = $@"Teste de
        quebra de linha {price}";
        Console.WriteLine(texto);

        // compara string
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("compara string");
        Console.WriteLine();
        texto = "Testando";
        Console.WriteLine(texto.CompareTo("Testando"));
        Console.WriteLine(texto.CompareTo("testando"));
        texto = "Esse texto é um teste";
        Console.WriteLine(texto.Contains("esse", StringComparison.OrdinalIgnoreCase));

        // start with , ends with
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("start with , ends with");
        Console.WriteLine();
        texto = "Começa com e termina com";
        Console.WriteLine(texto.StartsWith("começa com", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(texto.EndsWith("termina com", StringComparison.OrdinalIgnoreCase));

        // indices
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Indices");
        Console.WriteLine();
        Console.WriteLine(texto.IndexOf("ç"));
        Console.WriteLine(texto.LastIndexOf("m"));

        // Manipulando string
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Manipulando string");
        texto = "      Este é um teste    ";
        Console.WriteLine();
        Console.WriteLine(texto.Replace("teste", "texto"));

        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);

        Console.WriteLine(texto.Trim());

        // string builder
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("string builder");
        Console.WriteLine();
        var textoBuilder = new StringBuilder();
        textoBuilder.Append("Esse é um texto");
        textoBuilder.Append(" de teste");
        textoBuilder.Append(" para testar o string builder");
        Console.WriteLine(textoBuilder);
    }
}