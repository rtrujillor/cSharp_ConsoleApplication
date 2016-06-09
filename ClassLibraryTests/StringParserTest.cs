using NUnit.Framework;


namespace ClassLibrary1
{
    [TestFixture]
    class StringParserTest
    {
        [Test]
        public void Truncate_WithNull_ReturnsNull()
        {
            Assert.AreEqual(null, new StringParser().Truncate(null, 42));
        }

        [Test]
        public void AdjustWith_GivernInigoMontoya42_RetunrsInigoMontoyaExtended()
        {
            Assert.AreEqual(42, new StringParser().AdjustWith("Inigo Montoya" , 42).Length);
        }
    }
}
