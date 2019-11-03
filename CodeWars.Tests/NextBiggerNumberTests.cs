using CodeWars.ConsoleApp;
using NUnit.Framework;
using System;

namespace CodeWars.Tests
{
    public class NextBiggerNumberTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            Assert.AreEqual(21, NextBiggerNumber.GetNextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumber.GetNextBiggerNumber(513));
            Assert.AreEqual(2071, NextBiggerNumber.GetNextBiggerNumber(2017));
            Assert.AreEqual(441, NextBiggerNumber.GetNextBiggerNumber(414));
            Assert.AreEqual(3645, NextBiggerNumber.GetNextBiggerNumber(3564));
            Assert.AreEqual(1102, NextBiggerNumber.GetNextBiggerNumber(1021));    
        }
    }
}
