using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }

        public DbSet<Command> Commands { get; set; }
    }
}