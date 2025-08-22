namespace Dodernizer.DTO.Responses
{
    public class DTOAuthResult
    {
        /// <summary>
        /// Indicates whether the authentication was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The authentication token generated upon successful authentication.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// A list of error messages if authentication failed.
        /// </summary>
        public List<string> Errors { get; set; } = new List<string>();
    }
}
