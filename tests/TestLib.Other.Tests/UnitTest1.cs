using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLib.Other.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 testClass = new Class1();
            testClass.MyMethod(true);
            testClass.MyMethod(false);
        }
    }
}
