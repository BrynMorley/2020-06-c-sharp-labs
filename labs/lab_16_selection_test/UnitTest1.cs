using NUnit.Framework;
using lab_16_selection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection.Metadata;

namespace lab_16_selection_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mark40AndOverPasses()
        {
            var result = Selection.PassFail(40);
            Assert.AreEqual("Pass", result);
        }
        public void Mark39AndUnderFails()
        {
            var result = Selection.PassFail(20);
            Assert.AreEqual("Fail", result);
        }

        [TestCase(100)]
        [TestCase(75)]
        public void Mark75AndOverPassesWithDistinction (int mark)
        {
            var result = Selection.Grade(mark);
            Assert.AreEqual("Pass with Distinction", result);
        }
    }
}