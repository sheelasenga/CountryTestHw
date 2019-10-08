using System;
using NUnit.Framework;
using CountryAPI;

namespace Clothing.Test
  
{

    [TestFixture]
    public class CountryServiceTest
    {

        CountryCode countrycode = new CountryCode();

        public CountryServiceTest()
        {
            countrycode.GetCountry("Andorra");
        }
        [Test]
        public void Status()
        {
            Assert.AreEqual("200", countrycode.CountryResponseContent["code"].ToString());
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual("Andorra", countrycode.CountryResponseContent["result"][0]["name"].ToString());
        }

        [Test]
        public void CountryCode()
        {
            Assert.AreEqual("AD", countrycode.CountryResponseContent["result"][0]["code"].ToString());
        }


        [Test]
        public void CountryState()
        {
            Assert.AreEqual("", countrycode.CountryResponseContent["result"][0]["states"].ToString());
        }

        [Test]
        public void NotEqual()
        {
            Assert.AreNotEqual("Andorra", countrycode.CountryResponseContent["result"][1]["name"].ToString());
        }

        [Test]
        public void Header()
        {
         // Assert.AreEqual("Ok", countrycode.CountryResponseContent.Headers.Location.AbsoluteUri);
        }
    }
}