using NUnit.Framework;
using ProjetPourTU.Services;

namespace UnitTestProject
{
    public class Tests
    {
        MathsService m;
        [SetUp]
        public void Setup()
        {
            m = new MathsService();
        }

        [Test]
        public void test_multi()
        {
            int expected = 16;
            int result;

            result = m.Multiplier(4, 4);
            Assert.AreEqual(expected, result);
        }
        
    }
}