using System;
using Contexts;
using ModelTwo;
using NUnit.Framework;

namespace IntegrationTests
{
    [TestFixture]
    public class ModelTwoIntegrationTests : IntegrationTestBase
    {
        [Test]
        public void Should_Apply_Migrations_And_Seed_Database()
        {
            // Arrange
            var dbContext = new ModelTwoContext();
            var blog = new Blog { BlogId = Guid.NewGuid(), Topic = "Certification" };

            // Act
            var response = dbContext.Blogs.Add(blog);
            dbContext.SaveChanges();

            // Assert
            Assert.IsNotNull(response);
        }
    }
}