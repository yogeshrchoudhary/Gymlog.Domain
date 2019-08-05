using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gymlog.Domain.UnitTests
{
    [TestClass]
    public class PrioritizedTests
    {
        private static int order = 0;

        [ClassInitialize]
        public static void InitOnce(TestContext testContext)
        {
            order = 0;
        }

        public TestContext TestContext { get; set; }

        [TestMethod, Priority(1)]
        public void TwoTest()
        {
            order++;
            TestContext.WriteLine($"In TwoTest {order}");
            Console.WriteLine("TwoTest");
            Assert.IsTrue(true);
        }

        [TestMethod, Priority(2)]
        public void OneTest()
        {
            order++;
            TestContext.WriteLine($"In OneTest {order}");
            Console.WriteLine("OneTest");
            Assert.IsTrue(true);
        }
    }
}
