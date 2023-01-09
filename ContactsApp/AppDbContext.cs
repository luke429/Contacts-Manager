using Microsoft.EntityFrameworkCore;
using Models;

namespace ContactsApp

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
        public DbSet<Contact> Contacts { get; set; }
    }
}
