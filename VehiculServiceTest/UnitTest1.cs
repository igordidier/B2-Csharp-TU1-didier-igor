using NUnit.Framework;
using ProjetPourTU.Services;

namespace VehiculServiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            public void getByIDTest()
            {
                int VehiculeID = 7823732;
                var result = _testClass.getByID(VehiculeID);
                Assert.AreEqual(7823732, result);
            }
        }
    }
}