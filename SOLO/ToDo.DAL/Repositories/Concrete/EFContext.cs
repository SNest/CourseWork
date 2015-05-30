using System.Data.Entity;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("DBConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
