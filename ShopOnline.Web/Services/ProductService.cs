using ShopOnline.Models.Dtos;
using ShopOnline.Web.Pages;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
                this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> GetItems()
        {
           
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            
        }
        public async Task<IEnumerable<ProductDto>> GetItems2()
        {
           
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            
        }
    }
}
