namespace MeuApp;

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