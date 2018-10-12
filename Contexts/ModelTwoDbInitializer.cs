using System;
using System.Data.Entity;
using Contexts.ModelTwoMigrations;
using ModelTwo;

namespace Contexts
{
    //public class ModelTwoDbInitializer : DropCreateDatabaseAlways<ModelTwoContext>
    public class ModelTwoDbInitializer : MigrateDatabaseToLatestVersion<ModelTwoContext, ModelTwoDbConfiguration>
    {
        //protected override void Seed(ModelTwoContext context)
        //{
        //    base.Seed(context);

        //    var blog = new Blog { BlogId = Guid.NewGuid(), Topic = "Software Development" };
        //    context.Blogs.Add(blog);
        //    context.SaveChanges();

        //    var post = new Post { PostId = Guid.NewGuid(), BlogId = blog.BlogId, Content = "Scrum is awesome!" };
        //    context.Posts.Add(post);
        //    context.SaveChanges();
        //}

        public override void InitializeDatabase(ModelTwoContext context)
        {
            base.InitializeDatabase(context);

            var blog = new Blog { BlogId = Guid.NewGuid(), Topic = "Software Development" };
            context.Blogs.Add(blog);
            context.SaveChanges();

            var post = new Post { PostId = Guid.NewGuid(), BlogId = blog.BlogId, Content = "Scrum is awesome!" };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}