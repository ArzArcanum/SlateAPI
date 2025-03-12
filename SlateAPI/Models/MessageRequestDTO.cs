namespace SlateAPI.Models
{
    public class MessageRequestDTO
    {
        public required string UserId { get; set; }
        public required string Content { get; set; }
        // Add a date/timestamp property
    }
}