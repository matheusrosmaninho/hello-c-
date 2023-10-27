namespace MeuApp
{
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
            Console.WriteLine(EEstadoCivil.Casado);
        }

    }

    struct Product
    {
        public int Id;

        public string Name;

        public float Price;

        public Product(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }
}