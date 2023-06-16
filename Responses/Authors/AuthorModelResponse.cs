namespace DevTricks.Api.Responses.Authors
{
    /// <summary>
    /// Модель автора, возвращаемая контроллером (Response)
    /// </summary>
    public class AuthorModelResponse
    {

        /// <summary>
        /// Author Id
        /// </summary>
        public required int Id { get; init; }


        /// <summary>
        /// Author name
        /// </summary>
        public required string FirstName { get; init; }


        /// <summary>
        /// Author last name
        /// </summary>
        public required string LastName { get; init;}


        /// <summary>
        /// Author birthday
        /// </summary>
        public required DateOnly BirthDay { get; init; }

    }
}
