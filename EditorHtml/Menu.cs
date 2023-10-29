using System.Text;

namespace EditorHtml;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
    }

    public static void DrawScreen()
    {
        var draw = DrawHeaderAndFooterTable(30) + DrawLeftAndRigth(30, 10) + DrawHeaderAndFooterTable(30);
        Console.WriteLine(draw);
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor html");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("===========");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir arquivo");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 10);
        Console.Write("Opção: ");
    }

    private static string DrawHeaderAndFooterTable(int columns)
    {
        var draw = new StringBuilder();
        draw.Append('+');
        for (int i = 0; i <= columns; i++)
            draw.Append('-');
        draw.Append('+');
        draw.Append('\n');

        return draw.ToString();
    }

    private static string DrawLeftAndRigth(int columns, int lines)
    {
        var draw = new StringBuilder();

        for (int i = 0; i <= lines; i++) {
            draw.Append('|');
            for (int j = 0; j <= columns; j++)
                draw.Append(' ');
            draw.Append('|');
            draw.Append('\n');
        }

        return draw.ToString();
    }
}