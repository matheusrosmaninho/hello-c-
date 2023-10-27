namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Id = 1;
            product.Title = "teste";
            product.Price = 10;
            Console.WriteLine(product.PriceInDolar(5));
        }

    }

    struct Product
    {
        public int Id;
        public float Price;

        public string Title;

        public Product(int id, string title, float price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }
}