using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleUnitTests
{
    [TestClass]
    public class FindExecutionOrderOfTests
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void SirfEkBaarJiyega(TestContext testContext)
        {
            Console.WriteLine("In SirfEkBaarJiyega");
        }

        [ClassCleanup]
        public static void SirfEkBaarMarega()
        {
            Console.WriteLine("In SirfEkBaarMarega");
        }

        [TestInitialize]
        public void HameshaJiyega()
        {
            Console.WriteLine("In HameshaJiyega");
        }

        [TestCleanup]
        public void HameshaMarega()
        {
            Console.WriteLine("In HameshaMarega");
        }

        [TestMethod]
        public void TeesraTest()
        {
            Console.WriteLine("In TeesraTest");
        }

        [TestMethod]
        public void PahelaTest()
        {
            Console.WriteLine("In PahelaTest");
        }

        [TestMethod]
        public void DoosraTest()
        {
            Console.WriteLine("In DoosraTest");
        }
    }
}
