using Newtonsoft.Json.Bson;
using NUnit.Framework;
using NUnit.Framework.Constraints;
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
        public void CanAttemptCaptureMonster()
        {
            LaserGun w = new LaserGun("Test Weapon", "Test Weapon", 1);
            Monster m = new Monster("Test", 10) { IsElderDragon = false };
            MonsterHunter mh = new MonsterHunter("First", "Last", w, "Longsword");

            string expected = $"{mh.GetFullName()} attempts to capture {m.Name} ...... and caught it!";
            string expected2 = $"{mh.GetFullName()} attempts to capture {m.Name} ...... but it escaped!";
            string actual = mh.Capture(m);

            //Assert.That(actual.Equals(expected));
            //Assert.That(actual.Equals(expected2));
            
                Assert.AreEqual(actual, expected);
            
          
            Assert.AreEqual(actual, expected2);
            }

        [Test]
        public void AttackMonsterReportsCorrectly()
        {
            LaserGun w = new LaserGun("Test Weapon", "Test Weapon", 1);
            Monster m = new Monster("Test", 10);
            MonsterHunter mh = new MonsterHunter("First", "Last", w, w);

            string expected = $"{mh.GetFullName()} hits {m.Name} with {w.Name} doing {w.Damage} damage.";
            Assert.AreEqual(mh.Attack(m), expected);
        }

        [Test]
        public void WeaponWithOneDamageKills1HealthMonster()
        {

            LaserGun w = new LaserGun("Test Weapon", "Test Weapon", 1);
            Monster m = new Monster("Test", 1);
            MonsterHunter mh = new MonsterHunter("First", "Last", w, w);

            string expected = $"{mh.GetFullName()} hits {m.Name} with {w.Name} and kills it!";
            Assert.AreEqual(mh.Attack(m), expected);
        }




    }
      
      
    

    public class VehicleTests
    {
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

        [TestCase(5, 5)]
        [TestCase(10, 5)]
        [TestCase(-5, 0)]
        [TestCase(4, 4)]
        public void NumberOfPassangersIsWithinBounds(int passengers, int expected)
        {
            Vehicle v = new Vehicle(5);
            v.NumPassengers = passengers;
            var actual = v.NumPassengers;
            Assert.AreEqual(actual, expected);
        }

        [TestCase(-1, 0)] //no. of passengers = -1, expect 0
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 5)] //Pass, cuz am cool 
        public void VehicleCapacityTests(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5);
            v.NumPassengers = numPassengers;
            Assert.AreEqual(expectedPassengers, v.NumPassengers);
        }
        [Test]

        public void WhenMoveCalledItReturnsCorrectValueAfterAscend500andMove3Times()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);

            var actual = a.Move(3);

            var expected = "Moving along 3 times at an altitude of 500 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void ToStringCorrectWhenAscend500andMove3Times()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);

            var actual = a.ToString();

            var expected = "Thank you for flying JetsRUs: Safari_Park.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void WhenMoveCalledItReturnsCorrectValueAfterAscend500Move3TimesDescend200()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);

            var actual = a.Move();

            var expected = "Moving along at an altitude of 300 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToStringCorrectWhenAscend500andMove3TimesDescend200ThenCallMove()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            a.Move();
            a.Move();

            var actual = a.ToString();

            var expected = "Thank you for flying JetsRUs: Safari_Park.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.";
            Assert.AreEqual(expected, actual);
        }
    }
}
