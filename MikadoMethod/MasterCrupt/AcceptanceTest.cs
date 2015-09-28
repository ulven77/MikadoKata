using NUnit.Framework;

namespace MasterCrupt
{
    [TestFixture]
    internal class AcceptanceTest
    {
        [Test]
        public void TestSecret()
        {
            var ui = new UI();
            Assert.AreEqual("Leeted: S3cr3t", ui.EncryptMessage("Secret"));
        }
    }
}
