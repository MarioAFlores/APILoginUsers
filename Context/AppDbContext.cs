using APILoginUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace APILoginUsers.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Users> users { get; set; }
        public DbSet<User_Role> user_Roles { get; set; }

    }
}
