using electronic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace electronicTests
{
    [TestClass]
    public class resistorUnitTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            Assert.IsTrue(true);
        }

        // [TestMethod]
        // public void FailMethod()
        // {
        //     Assert.IsTrue(false);
        // }

        [TestMethod]
        public void CreateResistor()
        {
            var resistor = new Resistor();
        }
    }
}
