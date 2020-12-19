using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "Hello World!";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
