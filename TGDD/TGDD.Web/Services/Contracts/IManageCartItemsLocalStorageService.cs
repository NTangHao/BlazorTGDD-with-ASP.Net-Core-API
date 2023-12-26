using TGDD.Models.Dtos;

namespace TGDD.Web.Services.Contracts
{
    public interface IManageCartItemsLocalStorageService
    {
        Task<List<CartItemDto>> GetCollection(string username);
        Task SaveCollection(List<CartItemDto> cartItemDtos);
        Task RemoveCollection();
    }
}
