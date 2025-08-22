using System.ComponentModel.DataAnnotations;

namespace Dodernizer.DTO.DTOs
{
    public class DTOUser
    {
        /// <summary>
        /// First name of user
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name of user
        /// </summary>        
        [MaxLength(50)]
        public string? MiddleName { get; set; }        

        /// <summary>
        /// Last name of user
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Email of user
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Date of birth of user
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }
    }
}
