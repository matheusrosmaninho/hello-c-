namespace StopWatch;

using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu() {
        Console.Clear();
        Console.WriteLine("S = segundos => 10s = 10 segundos");
        Console.WriteLine("M = minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja rodar a aplicação?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multipliar = 1;

        if (type == 'm')
            multipliar = 60;

        if (time == 0)
            Environment.Exit(0);

        Start(time * multipliar);
    }

    public static void Start(int time)
    {
        int cuurentTime = 0;

        while(cuurentTime != time)
        {
            Console.Clear();
            cuurentTime++;
            Console.WriteLine(cuurentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stop watch finalizado ...");
        Thread.Sleep(2500);
        Menu();
    }
}