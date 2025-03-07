using System.ComponentModel.DataAnnotations;

namespace SlateAPI.Models
{
    public class Message
    {
        [Key]
        public long Id { get; set; } // Auto-incrementing ID
        public required long UserId { get; set; }
        public required string Content { get; set; }
        // Add a date/timestamp property
    }
}
