namespace Dodernizer.DTO.DTOs
{
    public class BaseDTO
    {
        /// <summary>
        /// User who created this entity
        /// </summary>        
        public int CreatedBy { get; set; }

        /// <summary>
        /// Date when entity was created
        /// </summary>        
        public DateTimeOffset CreationDate { get; set; }

        /// <summary>
        /// Date when entity was last modified
        /// </summary>
        public DateTimeOffset ModifyDate { get; set; }
    }
}
