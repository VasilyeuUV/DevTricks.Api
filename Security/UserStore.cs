using Microsoft.AspNetCore.Identity;

namespace DevTricks.Api.Security
{
    /// <summary>
    /// Хранилище Credentional Пользователя
    /// </summary>
    internal class UserStore : IUserPasswordStore<UserModel>
    {
        // - пока захардкодим нового Пользователя
        private readonly List<UserModel> _users = new()
        {
            new UserModel()
            {
                Email = "user@bookshelf.com",
                PasswordHash = "AQAAAAIAAYagAAAAEJ2ypbWnB4s4j5TsFJ2kANMspudEHSRhN28lGgxMBAzSK/bDh3XTu8Gri889qRXT6A=="
            }
            // для получения хэш-кода выполнить: new Microsoft.AspNetCore.Identity.PasswordHasher<object>().HashPassword(null,"strong_password")
        };


        //###############################################################################################################################
        #region IUserPasswordStore<UserModel>

        public void Dispose()
        {
        }


        public Task<string?> GetPasswordHashAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult((string?)user.PasswordHash);     // - возвращаем hash пароля переданного пользователя
        }


        public Task<UserModel?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var user = _users.FirstOrDefault(user => string.Equals(user.Email, normalizedUserName, StringComparison.InvariantCultureIgnoreCase));
            return Task.FromResult(user);   // - т.к. метод выше синхронный
        }


        //__________________________________________________________________________________________________________________________
        #region Don't used

        public Task<IdentityResult> CreateAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<IdentityResult> DeleteAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<UserModel?> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<string?> GetNormalizedUserNameAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<string> GetUserIdAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<string?> GetUserNameAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<bool> HasPasswordAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task SetNormalizedUserNameAsync(UserModel user, string? normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task SetPasswordHashAsync(UserModel user, string? passwordHash, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task SetUserNameAsync(UserModel user, string? userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public Task<IdentityResult> UpdateAsync(UserModel user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion // Don't used

        #endregion // IUserPasswordStore<UserModel>
    }
}
