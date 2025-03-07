using Microsoft.EntityFrameworkCore;
using SlateAPI.Models;

namespace SlateAPI.Models;

public class MessageContext : DbContext
{
    public MessageContext(DbContextOptions<MessageContext> options)
        : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Message>()
            .Property(m => m.Id)
            .ValueGeneratedOnAdd(); // Ensures ID is auto-generated
    }
}