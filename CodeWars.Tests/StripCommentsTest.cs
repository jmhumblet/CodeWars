using CodeWars.ConsoleApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    public class StripCommentsTest
    {
        [Test]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears\ngrapes\nbananas",
                    StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }
    }
}
