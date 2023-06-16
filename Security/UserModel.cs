namespace DevTricks.Api.Security
{
    /// <summary>
    /// Доменная сущность Пользователя
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Адрес электронной почты в качестве идентификатора Пользователя
        /// </summary>
        public required string Email { get; init; }


        /// <summary>
        /// Хэш пароля (не храним пароль в открытом виде). 
        /// </summary>
        public required string PasswordHash { get; init; }
    }
}
