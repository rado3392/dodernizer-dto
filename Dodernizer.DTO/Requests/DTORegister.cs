using System.ComponentModel.DataAnnotations;

namespace Dodernizer.DTO.Requests
{
    public class DTORegister
    {
        /// <summary>
        /// First name of the user.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name of the user (optional).
        /// </summary>        
        [MaxLength(50)]
        public string? MiddleName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the user. It must be a valid email format.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The password for the user. Must meet security requirements.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// The date of birth of the user.
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
