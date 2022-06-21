﻿

namespace EcommerceBlazor.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        //http is used to request calls (CRUD)
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        //calls a controller and get a product by Id
        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            //if no categoryUrl - all products, if url - category by its categoryUrl
            var result =
                categoryUrl == null ? 
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/category/{categoryUrl}");                ; 
            if (result != null && result.Data != null)
                Products = result.Data;

            //After using GetProducts method in a component
            //The event will Invoke and subscribe to some other method
            ProductsChanged.Invoke();
        }
    }
}
