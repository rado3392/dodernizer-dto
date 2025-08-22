using System.ComponentModel.DataAnnotations;

namespace Dodernizer.DTO.DTOs
{
    public class DTOGroup
    {
        /// <summary>
        /// Name of group
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Description of group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Members of group
        /// </summary>
        public IList<DTOUser> Members { get; set; }
    }
}
