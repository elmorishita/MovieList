using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
    
{
    public class PhoneContext : DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options) 
            : base(options) 
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Nacho Libre",
                    Phone = "5554443333",
                    Address = "123 Main St.  Mexicali, MX 12345",
                    Note = "The egg was a lie Steven"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Batman",
                    Phone = "UNK",
                    Address = "The batcave",
                    Note = "I am the night"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Lil John",
                    Phone = "1234567890",
                    Address = "The dirty south",
                    Note = "OKAY!"
                }
                );
        }
    }
}
