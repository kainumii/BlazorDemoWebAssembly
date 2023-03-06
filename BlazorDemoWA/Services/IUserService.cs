using BlazorDemoWA.Shared.Domain;

namespace BlazorDemoWA.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUserById(int userId);

        Task UpdateUser(User user);

        Task<User> AddUser(User user);

        Task DeleteUser(int id);
    }
}
