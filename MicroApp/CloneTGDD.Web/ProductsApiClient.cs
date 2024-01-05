
using CloneTGDD.Web.Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace CloneTGDD.Web
{
    public class ProductsApiClient(HttpClient client)
    {
        private readonly string remoteServiceBaseUrl = "/api";
        public async Task<ResponseDTO> GetProductsDTO()
        {
            var uri = $"{remoteServiceBaseUrl}/products";
            return await client.GetFromJsonAsync<ResponseDTO>(uri) ?? throw new Exception("The API response was null.");
        }

        public async Task<ResponseDTO> GetProductsDTOById(int id)
        {
            var uri = $"{remoteServiceBaseUrl}/items/{id}";
            return await client.GetFromJsonAsync<ResponseDTO>(uri) ?? throw new Exception("The API response was null.");
        }

        public async Task<ResponseDTO> SearchProduct(string searchTerm)
        {
            var uri = $"{remoteServiceBaseUrl}/items?searchTerm={searchTerm}";
            return await client.GetFromJsonAsync<ResponseDTO>(uri) ?? throw new Exception("The API response was null.");
        }

        public async Task<ResponseDTO> GetProductsByCategory(string category)
        {
            var uri = $"{remoteServiceBaseUrl}/products/{category}";
            return await client.GetFromJsonAsync<ResponseDTO>(uri) ?? throw new Exception("The API response was null.");
        }

    }
}
