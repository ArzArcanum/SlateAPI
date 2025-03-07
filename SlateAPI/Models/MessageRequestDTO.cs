namespace SlateAPI.Models
{
    public class MessageRequestDTO
    {
        public required long UserId { get; set; }
        public required string Content { get; set; }
        // Add a date/timestamp property
    }
}