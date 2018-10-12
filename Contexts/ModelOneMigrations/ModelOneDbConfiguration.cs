using System.Data.Entity.Migrations;

namespace Contexts.ModelOneMigrations
{
    public sealed class ModelOneDbConfiguration : DbMigrationsConfiguration<ModelOneContext>
    {
        public ModelOneDbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ModelOneMigrations";
        }

        protected override void Seed(ModelOneContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
