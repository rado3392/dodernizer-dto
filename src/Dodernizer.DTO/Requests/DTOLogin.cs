using System.ComponentModel.DataAnnotations;

namespace Dodernizer.DTO.Requests
{
    public class DTOLogin
    {
        /// <summary>
        /// The email address of the user. It must be a valid email format.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The password for the user to log in.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
