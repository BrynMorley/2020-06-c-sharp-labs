using NUnit.Framework;
using System;
using lab_20_Exceptions;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace lab_20_exception
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
{
        [TestCase(4)]
        public void Test1(int pos)
        {
           
            var ex = Assert.Throws<ArgumentException>(() => Beatle.AddBeatle(pos, "Brian"));
            Assert.AreEqual($"The Beatles do not have a posiotn {pos}", ex.Message, "Exeception message not correct");
            
        }
    }
}