namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine("O resultado é " + resultado);
        Console.WriteLine($"O resultado é: {resultado}");
    }
}