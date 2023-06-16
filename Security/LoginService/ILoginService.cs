using DevTricks.Api.Requests.User;
using DevTricks.Api.Responses.User;

namespace DevTricks.Api.Security.LoginService
{
    /// <summary>
    /// Контракт сервиса, отвечающего за авторизацию
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task<LoginModelResponse?> LoginAsync(LoginModelRequest request);
    }
}
