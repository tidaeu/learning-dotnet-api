using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data 
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base (opt){}

        // This is basically a table
        public DbSet<Command> Commands { get; set; }
    }
}