using DevTricks.Api.Responses.Authors;
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

        /// <summary>
        /// Получение коллекции автров (endpoint)
        /// </summary>
        /// <returns></returns>
        [HttpGet]                   // - метод является get-endpoint
        [Route("all")]              // - метод доступен по маршруту "all"
        public AuthorCollectionResponse GetAuthorCollection()
        {
            return new AuthorCollectionResponse()
            {
                Items = new[]
                {
                    new AuthorModelResponse()
                    {
                        Id = 1,
                        FirstName = "William",
                        LastName = "Shakespeare",
                        BirthDay = new DateOnly(1564, 04, 26)
                    },
                    new AuthorModelResponse()
                    {
                        Id = 2,
                        FirstName = "George",
                        LastName = "Show",
                        BirthDay = new DateOnly(1856, 07, 26)
                    }
                }
            };
        }
    }
}
