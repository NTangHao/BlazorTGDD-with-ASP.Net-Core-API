using Blazored.LocalStorage;
using TGDD.Api.Entities;
using TGDD.Models.Dtos;
using TGDD.Web.Services.Contracts;

namespace TGDD.Web.Services
{
    public class ManageCartItemsLocalStorageService : IManageCartItemsLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IShoppingCartService shoppingCartService;
        private readonly ICartService cartService;
        const string key = "CartItemCollection";

        public ManageCartItemsLocalStorageService(ILocalStorageService localStorageService,
                                                  IShoppingCartService shoppingCartService,
                                                  ICartService cartService)
        {
            this.localStorageService = localStorageService;
            this.shoppingCartService = shoppingCartService;
            this.cartService = cartService;
        }

        public async Task<List<CartItemDto>> GetCollection(string username)
        {
            // Lấy ra khỏi localStorage nếu ko có thì gọi api đưa vào 
            return await this.localStorageService.GetItemAsync<List<CartItemDto>>(key)
                    ?? await AddCollection(username);
        }

        public async Task RemoveCollection()
        {
            await this.localStorageService.RemoveItemAsync(key);
        }

        public async Task SaveCollection(List<CartItemDto> cartItemDtos)
        {
            await this.localStorageService.SetItemAsync(key, cartItemDtos);
        }

        private async Task<List<CartItemDto>> AddCollection(string username)
        {
            User usercart = new User();
            usercart = await cartService.GetUserByName(username);
            var shoppingCartCollection = await this.shoppingCartService.GetItems(usercart.Id);

            if (shoppingCartCollection != null)
            {
                // Đưa vào localStorage
                await this.localStorageService.SetItemAsync(key, shoppingCartCollection);
            }

            return shoppingCartCollection;

        }

    }
}
