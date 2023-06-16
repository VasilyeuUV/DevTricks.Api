using DevTricks.Api.Requests.User;
using DevTricks.Api.Responses.User;
using Microsoft.AspNetCore.Identity;

namespace DevTricks.Api.Security.LoginService
{
    internal class LoginService : ILoginService
    {
        private readonly UserManager<UserModel> _userManager;


        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="user">Часть системной идентификации пользователя</param>
        public LoginService(UserManager<UserModel> user)
        {
            this._userManager = user;
        }


        //###############################################################################################################################
        #region ILoginService

        public async Task<LoginModelResponse?> LoginAsync(LoginModelRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.Email);
            if (user == null) 
                return null;

            // - проверка переданного пароля (в этот момент фроэймворк  сформирует Hash для переданного пароля)
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);
            return isPasswordValid 
                ? new LoginModelResponse() 
                : null;
        }

        #endregion // ILoginService

    }
}
