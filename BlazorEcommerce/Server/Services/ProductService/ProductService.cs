namespace BlazorEcommerce.Server.Services.ProductService
{

    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            throw new NotImplementedException();
        }
    }
}
