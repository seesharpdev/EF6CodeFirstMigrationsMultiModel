using System;
using Contexts;
using ModelOne;
using NUnit.Framework;

namespace IntegrationTests
{
    [TestFixture]
    public class ModelOneIntegrationTests : IntegrationTestBase
    {
        [Test]
        public void Should_Apply_Migrations_And_Seed_Database()
        {
            // Arrange
            var dbContext = new ModelOneContext();
            var user = new User { UserId = Guid.NewGuid(), Username = "Username" };

            // Act
            var response = dbContext.Users.Add(user);
            dbContext.SaveChanges();

            // Assert
            Assert.IsNotNull(response);
        }
    }
}
