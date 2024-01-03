using TGDD.Api.Entities;

namespace TGDD.Web.Services.Contracts
{
    public interface ICartService
    {
        Task<Cart> AddItem(int userId);
        Task<User> GetUserByName(string name);
        Task<Cart> GetCartByUserID(int userid);
    }
}
