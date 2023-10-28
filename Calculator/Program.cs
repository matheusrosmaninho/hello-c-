namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o operador:");
        Console.WriteLine(" 1 - soma");
        Console.WriteLine(" 2 - subtração");
        int operador = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Calculator calculator = new Calculator(v1, operador, v2);

        float resultado = calculator.Resultado();

        Console.WriteLine("O resultado é " + resultado);
        Console.WriteLine($"O resultado é: {resultado}");
    }
}