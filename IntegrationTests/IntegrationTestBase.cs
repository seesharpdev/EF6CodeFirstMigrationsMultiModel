using System;
using NUnit.Framework;

namespace IntegrationTests
{
    public class IntegrationTestBase
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
