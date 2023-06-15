namespace DevTricks.Api.Responses.Authors
{
    /// <summary>
    /// Модель автора, возвращаемая контроллером (Response)
    /// </summary>
    public class AuthorModelResponse
    {

        /// <summary>
        /// Id автора
        /// </summary>
        public required int Id { get; init; }


        /// <summary>
        /// Имя автора
        /// </summary>
        public required string FirstName { get; init; }


        /// <summary>
        /// Фамилия автора
        /// </summary>
        public required string LastName { get; init;}


        /// <summary>
        /// Лень рождения автора
        /// </summary>
        public required DateOnly BirthDay { get; init; }

    }
}
