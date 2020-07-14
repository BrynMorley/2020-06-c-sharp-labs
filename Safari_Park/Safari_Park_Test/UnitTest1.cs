using Newtonsoft.Json.Bson;
using NUnit.Framework;
using Safari_Park;

namespace Safari_Park_Test
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy","French","Cathy French")]
        [TestCase("",""," ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var instance = new Person(fName, lName);
            var actual = instance.GetFullName();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25,25)]
        public void AgeTest(int age, int expected)
        {
            var instance = new Person();
            instance.Age = age;
            var actual = instance.Age;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [TestCase(5,5)]
        [TestCase(10,5)]
        [TestCase(-5,0)]       
        public void NumberOfPassangersIsWithinBounds(int passengers, int expected)
        {
            Vehicle v = new Vehicle(5, 10);
            v.NumPassengers = passengers;
            var actual = v.NumPassengers;
            Assert.AreEqual(actual,expected);
        }
    }
}