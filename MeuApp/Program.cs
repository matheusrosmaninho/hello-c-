namespace MeuApp;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product
        {
            Id = 1,
            Name = "teste",
            Price = 10
        };
        Console.WriteLine(product.PriceInDolar(5));

        var cliente = new Cliente(1, EEstadoCivil.Casado);
        Console.WriteLine((int)cliente.EstadoCivil);
        Console.WriteLine(cliente.EstadoCivil);
    }

}