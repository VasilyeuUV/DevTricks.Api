namespace DevTricks.Api.Responses.Authors
{
    /// <summary>
    /// Response для коллекции авторов
    /// </summary>
    public class AuthorCollectionResponse
    {

        /// <summary>
        /// Список Авторов
        /// </summary>
        public required IEnumerable<AuthorModelResponse> Items { get; init; }
    }
}
