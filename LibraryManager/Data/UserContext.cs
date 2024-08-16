using Microsoft.EntityFrameworkCore;
using LibraryManager.Models;

namespace LibraryManager.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> option) : base(option) { }

        public DbSet<User> users { get; set;}
    }
}