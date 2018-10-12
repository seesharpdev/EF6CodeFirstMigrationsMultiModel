using System.Data.Entity.Migrations;

namespace Contexts.ModelTwoMigrations
{
    public sealed class ModelTwoDbConfiguration : DbMigrationsConfiguration<ModelTwoContext>
    {
        public ModelTwoDbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ModelTwoMigrations";
        }

        protected override void Seed(ModelTwoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
