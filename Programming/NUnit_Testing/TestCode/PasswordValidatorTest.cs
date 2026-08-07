using System;
using System.Collections.Generic;
using System.Text;
using ProductionCode;

namespace TestCode
{
    internal class PasswordValidatorTest
    {
        private PasswordValidator pv;

        [SetUp]
        public void SetUp()
        {
            pv= new PasswordValidator();
        }

        [Test]
        [TestCase("Kashvi123",true)]
        [TestCase("HargunDeep", false)]
        [TestCase("KashviHello123", true)]

        public void Validate_Password_ReturnTrueOrFalse(string password, bool expected)
        {
            bool result = pv.PasswordCheck(password);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
