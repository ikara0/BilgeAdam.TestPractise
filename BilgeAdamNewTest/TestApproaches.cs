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
            var logger = TypeLogger.GetProperties<Product>();
            Assert.AreEqual("System.ObjectSystem.Collections.Generic.IEnumerable`1[BilgeAdam.TestPractise.Product]System.Collections.IEnumerableSystem.Collections.Generic.IEnumerator`1[BilgeAdam.TestPractise.Product]System.IDisposableSystem.Collections.IEnumerator", logger);

        }
    }
}
