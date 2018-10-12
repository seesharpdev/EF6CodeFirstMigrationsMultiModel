using System.Data.Entity;
using ModelTwo;

namespace Contexts
{
    public class ModelTwoContext : DbContext
    {
        public ModelTwoContext()
            : base("MultipleModelDb")
        {
            Database.SetInitializer(new ModelTwoDbInitializer());
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
