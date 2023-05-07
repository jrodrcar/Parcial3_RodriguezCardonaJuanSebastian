using Microsoft.AspNetCore.Identity;
using Parcial3_RodriguezCardonaJuanSebastian.DAL;
using Parcial3_RodriguezCardonaJuanSebastian.Models;

namespace Parcial3_RodriguezCardonaJuanSebastian.Helpers
{
    public class IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<User> AddUserAsync(AddUserViewModel addUserViewModel);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel loginViewModel);

        Task LogoutAsync();

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<User> GetUserAsync(Guid userId); //Sobrecargado
    }
}
