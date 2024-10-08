using Core.DTOs;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> LoginAsync(string username, string password);
        Task<UserDto> GetUserByIdAsync(Guid userId);
        Task<User> GetUserByUsername(string username);
    }
}
