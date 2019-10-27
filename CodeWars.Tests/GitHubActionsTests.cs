using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    class GitHubActionsTests
    {
        [Test]
        public void PassingTest()
        {

        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail("FAIIIIIIL");
        }
    }
}
