namespace Lista;

class Program
{
    public static void Main(string[] args)
    {
        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() {Id = 2579, Nome = "André"};

        foreach(var funcionario in funcionarios) {
            Console.WriteLine(funcionario.Id);
            Console.WriteLine(funcionario.Nome);
        }
    }
}

public struct Funcionario {
    public int Id { get; set; }

    public string Nome {get; set;}
}