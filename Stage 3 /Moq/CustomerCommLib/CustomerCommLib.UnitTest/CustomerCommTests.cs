using Moq;
using NUnit.Framework;
using System;

namespace CustomerCommLib.UnitTest
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> moqMailSender;

        [OneTimeSetUp]
        public void Init()
        {
            moqMailSender = new Mock<IMailSender>();
            moqMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        }

        [Test]
        public void SendMailToCustomer_WhenCalled_ReturnTrue()
        {
            var customerComm = new CustomerComm(moqMailSender.Object);
            var result = customerComm.SendMailToCustomer();

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
