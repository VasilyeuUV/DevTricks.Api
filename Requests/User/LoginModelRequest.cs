namespace DevTricks.Api.Requests.User
{

    /// <summary>
    /// Credentionals для авторизации пользователя
    /// </summary>
    public class LoginModelRequest
    {
        /// <summary>
        /// Адрес электронной почты в качестве идентификатора Пользователя
        /// (гарантирует принадлежность к одному пользователю, в отличие от ника или userName)
        /// </summary>
        public required string Email { get; init; }


        /// <summary>
        /// Пароль
        /// </summary>
        public required string Password { get; init; }
    }
}
