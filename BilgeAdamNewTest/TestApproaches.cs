using BilgeAdam.TestPractise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdamNewTest
{
    internal class TestApproaches
    {
        [Test]
        public void TypeLogger_Class()
        {
            var helper = new TypeLogger();
            var logger = helper.GetTypeProperties<Product>();
            Assert.AreEqual("BilgeAdam.Product,Product,Class", logger);

        }
    }
}
