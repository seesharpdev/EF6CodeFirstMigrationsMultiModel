using System.Data.Entity;
using ModelOne;

namespace Contexts
{
    public class ModelOneContext : DbContext
    {
        public ModelOneContext()
            : base("MultipleModelDb")
        {
            Database.SetInitializer(new ModelOneDbInitializer());
        }

        public DbSet<User> Users { get; set; }
    }
}
