using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        public Task GetProducts();
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
