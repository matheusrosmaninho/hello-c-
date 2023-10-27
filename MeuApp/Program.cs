namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Id = 1;
            product.Name = "teste";
            product.Price = 10;
            Console.WriteLine(product.PriceInDolar(5));
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