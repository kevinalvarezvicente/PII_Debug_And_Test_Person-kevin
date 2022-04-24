using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person john;
        [SetUp]
        public void Setup()
        {
            john = new Person("John Doe", "5.354.596-4");
        }

        [Test]
        [TestCase("5.354.596-3", "5.354.596-4")]
        public void TestIdLastDigitInvalid(string idNew, string expected)
        {
            john.ID = idNew;
            string result = john.ID;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("5.354.596", "5.354.596-4")]
        public void TestIdLastDigitNull(string idNew, string expected)
        {
            john.ID = idNew;
            string result = john.ID;
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase("5.354.596-0", "5.354.596-4")]
        public void TestIdLastDigitCero(string idNew, string expected)
        {
            john.ID = idNew;
            string result = john.ID;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("5.354", "5.354.596-4")]
        public void LenghtId(string idNew, string expected)
        {
            john.ID = idNew;
            string result = john.ID;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("5.536.431-2", "5.536.431-2")]
        public void IdValid(string idNew, string expected)
        {
            john.ID = idNew;
            string result = john.ID;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(null, "John Doe")]
        public void NameNull(string nameNew, string expected)
        {
            john.Name = nameNew;
            string result = john.Name;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("", "John Doe")]
        public void NameEmpty(string nameNew, string expected)
        {
            john.Name = nameNew;
            string result = john.Name;
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("Anastasia Rose", "Anastasia Rose")]
        public void NameValid(string nameNew, string expected)
        {
            john.Name = nameNew;
            string result = john.Name;
            Assert.AreEqual(expected, result);
        }
    }
}