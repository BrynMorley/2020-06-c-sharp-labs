using NUnit.Framework;
using lab_15_Unit_Testing;
using System.IO.Pipes;

namespace Lab_15_methods_test
{
    public class Tests
    {
        private int _result;
        private int _sum;

        [SetUp]
        public void Setup()
        {
            //_result = Calc.TripleCalc(10, 2, 4, out int sum);
            //_sum = sum;
        }

        [TestCase(10,2,4,80)]
        [TestCase(5,2,2,20)]
        [TestCase(0,2,4,0)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Calc.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,2,4,16)]
        [TestCase(5, 2, 2, 9)]
        [TestCase(0, 2, 4, 6)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            Calc.TripleCalc(a, b, c, out int sum);

            Assert.AreEqual(expected, sum);
        }
    }
}