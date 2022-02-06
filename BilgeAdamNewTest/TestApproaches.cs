using BilgeAdam.TestPractise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdamNewTest
{
    [TestFixture]
    internal class TestApproaches
    {
        [Test]
        public void TypeLogger_Class()
        {
            RunTypeLoggerTest<Product>("BilgeAdam.TestPractise.Product,Product,Class,");
            RunTypeLoggerTest<Category>("BilgeAdam.TestPractise.Category,Category,Enum,ValueType,IComparable,IFormattable,IConvertible,");

        }

        private static void RunTypeLoggerTest<T>(string expection)
        {
            var helper = new TypeLogger();
            var logger = helper.GetTypeProperties<T>();
            Assert.AreEqual(expection, logger);
        }
    }
}
