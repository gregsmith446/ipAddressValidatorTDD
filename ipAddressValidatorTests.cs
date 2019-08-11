using ipAddressValidatorClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ipAddressValidatorTests
{
    [TestFixture]
    public class IpAddressValidatorTest
    {
        [Test]
        public void GivenIPaddressWithLengthOf4ReturnsTrue()
        {
            string address = "192.168.1.1";

            bool expected = true;
            bool output = new Validator().ValidateIpv4Address(address);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void GivenIPaddressWithLengthLessThan4ReturnsFalse()
        {
            string address = "10.0.1";

            bool expected = false;
            bool output = new Validator().ValidateIpv4Address(address);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void GivenIPaddressEndingIn255ReturnsFalse()
        {
            string address = "192.168.1.255";

            bool expected = false;
            bool output = new Validator().ValidateIpv4Address(address);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void GivenIPaddressEndingIn0ReturnsFalse()
        {
            string address = "192.168.1.0";

            bool expected = false;
            bool output = new Validator().ValidateIpv4Address(address);

            Assert.AreEqual(expected, output);
        }

    }
}
