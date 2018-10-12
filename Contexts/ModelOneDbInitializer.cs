using System;
using System.Data.Entity;
using Contexts.ModelOneMigrations;
using ModelOne;

namespace Contexts
{
    public class ModelOneDbInitializer : MigrateDatabaseToLatestVersion<ModelOneContext, ModelOneDbConfiguration>
    {
        //protected override void Seed(ModelOneContext context)
        //{
        //    base.Seed(context);

        //    var user = new User { UserId = Guid.NewGuid(), Username = "Administrtator" };
        //    context.Users.Add(user);
        //    context.SaveChanges();
        //}

        public override void InitializeDatabase(ModelOneContext context)
        {
            base.InitializeDatabase(context);

            var user = new User { UserId = Guid.NewGuid(), Username = "Administrtator" };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}