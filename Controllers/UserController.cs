using DevTricks.Api.Requests.User;
using DevTricks.Api.Security.LoginService;
using Microsoft.AspNetCore.Mvc;

namespace DevTricks.Api.Controllers
{
    /// <summary>
    /// Конроллер для пользователя
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILoginService _loginService;


        /// <summary>
        /// CTOR
        /// </summary>
        public UserController(ILoginService loginService)
        {
            this._loginService = loginService;
        }


        /// <summary>
        /// Эндпоинт Логин
        /// </summary>
        /// <param name="request">должен быть взят из тела запроса ([FromBody])</param>
        /// <returns></returns>
        [HttpPost]                                      // - использует Post-запрос
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModelRequest request) 
        { 
            var loginResponse = await _loginService.LoginAsync(request);
            return loginResponse == null
                ? Unauthorized()                // - неавторизирован (описан в базовом классе контроллера)
                : Ok(loginResponse);            // - успешная авторизация
        }
    }
}
