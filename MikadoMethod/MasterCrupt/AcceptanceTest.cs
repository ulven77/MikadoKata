using NUnit.Framework;

namespace MasterCrupt
{
    [TestFixture]
    internal class AcceptanceTest
    {
        [Test]
        public void TestSecretNSA()
        {
            var ui = new UI();
            Assert.AreEqual("Leeted: S3cr3t", ui.EncryptMessage("Secret", 1));
        }


        [Test]
        public void TestSecretCustomerFRA()
        {
            var ui = new UI();
            Assert.AreEqual("Leeted: 53cr3t", ui.EncryptMessage("Secret", 2));
        }
    }
}
