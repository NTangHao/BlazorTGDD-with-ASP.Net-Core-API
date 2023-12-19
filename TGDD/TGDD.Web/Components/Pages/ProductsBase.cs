using Microsoft.AspNetCore.Components;
using TGDD.Models.Dtos;
using TGDD.Web.Services.Contracts;

namespace TGDD.Web.Components.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Products = await ProductService.GetItems();

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }

        }

    }
}
