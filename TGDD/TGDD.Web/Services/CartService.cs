using TGDD.Api.Entities;
using TGDD.Web.Services.Contracts;

namespace TGDD.Web.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;

        public CartService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<User> GetUserByName(string name)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Users/{name}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(User);
                    }

                    return await response.Content.ReadFromJsonAsync<User>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<Cart> AddItem(int userId)
        {
            try
            {
                Cart cart = new Cart()
                {
                    UserId = userId
                };

                var response = await _httpClient.PostAsJsonAsync<int>("api/Carts", userId);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(Cart);
                    }

                    return await response.Content.ReadFromJsonAsync<Cart>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message -{message}");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<Cart> GetCartByUserID(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Carts/User/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(Cart);
                    }

                    return await response.Content.ReadFromJsonAsync<Cart>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
