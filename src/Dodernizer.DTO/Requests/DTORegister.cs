using Dodernizer.DTO.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Dodernizer.DTO.Requests
{
    public class DTORegister:DTOUser
    {
        /// <summary>
        /// The password for the user. Must meet security requirements.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
