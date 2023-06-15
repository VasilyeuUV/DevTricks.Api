using Microsoft.AspNetCore.Mvc;

namespace DevTricks.Api.Controllers
{
    /// <summary>
    /// Контроллер для авторов книг
    /// </summary>
    [ApiController]                     // - атрибут, указывающий, что контроллер является контроллером API
    [Route("[controller]")]             // - маршрутизатор контроллера. указывает системе маршрутизации использовать имя класса без суффикса "controller"
    public class AuthorController : ControllerBase
    {
    }
}
