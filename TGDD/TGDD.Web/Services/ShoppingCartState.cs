using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TGDD.Models.Dtos;
using TGDD.Web.Services.Contracts;

namespace TGDD.Web.Services
{
    public class ShoppingCartState
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        public List<CartItemDto> ShoppingCartItems { get; set; }
        public ProductDto Product { get; set; }

        public event Action? OnChange;

        //protected async Task AddToCartList(CartItemToAddDto cartItemToAddDto)
        //{
        //    try
        //    {
        //        var cartItemDto = await ShoppingCartService.AddItem(cartItemToAddDto);

        //        if (cartItemDto != null)
        //        {
        //            ShoppingCartItems.Add(cartItemDto);
        //            NotifyStateChanged();
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        //Log Exception
        //    }
        //}

        public async void AddToCartList(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var cartItemDto = await ShoppingCartService.AddItem(cartItemToAddDto);
                if (cartItemDto != null)
                {
                    ShoppingCartItems.Add(cartItemDto);
                    NotifyStateChanged();
                }
            }
            catch (Exception)
            {

            }

        }

        public async void RemoveFromCartList(CartItemDto cartItemDtos)
        {
            try
            {
                var cartItemDto = await ShoppingCartService.DeleteItem(cartItemDtos.CartId);
                if (cartItemDto != null)
                {
                    ShoppingCartItems.Remove(cartItemDto);
                    NotifyStateChanged();
                }
            }
            catch (Exception)
            {

            }

        }

        public void IncreaseProductQuantity(ProductDto product)
        {
            product.Qty++;
            NotifyStateChanged();
        }

        public void DecreaseProductQuantity(ProductDto product)
        {
            if (product.Qty > 1)
            {
                product.Qty--;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();


    }
}
