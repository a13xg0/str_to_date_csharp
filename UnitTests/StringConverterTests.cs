using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using str_to_date_mssql;

namespace UnitTests
{
    [TestFixture]
    public class StringConverterTests
    {
        [Test]
        public void UseConvert_ExpectedFormat_RightAssignment()
        {
            DateTime result = StringConverter.UseConvert("2017-01-23");

            Assert.AreEqual(2017, result.Year);
            Assert.AreEqual(1, result.Month);
            Assert.AreEqual(23, result.Day);
        }

        [Test]
        public void UseParse_ExpectedFormat_RightAssignment()
        {
            DateTime result = StringConverter.UseParse("2017-01-23");

            Assert.AreEqual(2017, result.Year);
            Assert.AreEqual(1, result.Month);
            Assert.AreEqual(23, result.Day);
        }

        [Test]
        public void UseParseWithDots_WrongFormat_Exception()
        {

            Assert.Catch(
                delegate {
                    StringConverter.UseParseWithDots("2017-01-23");
                }
            );
          
        }

        [Test]
        public void UseParseWithDots_ExpectedFormat_RightAssignment()
        {

            DateTime result = StringConverter.UseParseWithDots("23.01.2017");

            Assert.AreEqual(2017, result.Year);
            Assert.AreEqual(1, result.Month);
            Assert.AreEqual(23, result.Day);

        }

    }
}
