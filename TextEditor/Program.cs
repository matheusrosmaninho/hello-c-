namespace TextEditor;

class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                Abrir();
                break;
            case 2:
                Editar();
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }

    public static void Abrir() { }

    public static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("--------------------------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Write(text);
    }
}