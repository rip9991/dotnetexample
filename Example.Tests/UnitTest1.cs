using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    [TestClass]
    public class UnitTest1
    {
        ForExample _forExample = new ForExample();
        
        [TestMethod]
        public void TestMethod1()
        {
            var result = _forExample.Lab();
            Assert.AreEqual(5, result);
        }
    }
}
