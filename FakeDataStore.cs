namespace ExampleCQRSMediatR
{
    public class FakeDataStore
    {
        public static List<Product> _products;

        public FakeDataStore()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bread",
                    Price = 2.15M
                },
                new Product
                {
                    Id = 2,
                    Name = "Milk",
                    Price = 4.85M
                },
                new Product
                {
                    Id = 3,
                    Name = "Butter",
                    Price = 6.15M
                }
            };
        }

        public async Task CreateProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetllAllProducts() => await Task.FromResult(_products);
        public async Task<Product> GetProductById(int id) => await Task.FromResult(_products.Single(x => x.Id == id));

        public async Task EventOccurred(Product product, string evt)
        {
            _products.Single(x => x.Id == product.Id).Name = $"{product.Name} event {evt}";
            await Task.CompletedTask;
        }
    }
}
