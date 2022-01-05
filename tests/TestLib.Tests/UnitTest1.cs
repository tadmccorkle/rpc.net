using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 testClass = new Class1();
            testClass.MyMethod(false);
            testClass.MyObj = true;
            testClass.MyMethod((bool)testClass.MyObj);
            testClass.MyMethod(false, true);
            testClass.MyMethod(true, true);
        }
    }
}
