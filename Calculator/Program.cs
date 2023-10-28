namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        int opcao = Menu();

        if (opcao == 5) {
            Environment.Exit(3);
        }

        Console.WriteLine("Digite o primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Calculator calculator = new Calculator(v1, opcao, v2);
        float resultado = calculator.Resultado();

        Console.WriteLine($"O resultado da {(EOperador)opcao} é: {resultado}");
    }

    private static int Menu()
    {
        int? opcao = null;
        Console.WriteLine("Seja bem vindo a calculadora em c#");

        do
        {
            if (opcao.HasValue) {
                Console.WriteLine("Valor digitado não corresponde com as opções dadas ...");
            }
            Console.WriteLine("Digite o que deseja fazer:");
            Console.WriteLine(" 1 - soma");
            Console.WriteLine(" 2 - subtração");
            Console.WriteLine(" 3 - multiplicação");
            Console.WriteLine(" 4 - Divisão");
            Console.WriteLine(" 5 - Sair");

            opcao = int.Parse(Console.ReadLine());
        } while(!opcao.HasValue || (opcao < 1 || opcao > 5));

        return (int)opcao;
    }
}