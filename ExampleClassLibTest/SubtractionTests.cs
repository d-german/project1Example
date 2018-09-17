using ExampleClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleClassLibTest
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void SubtractionTest()
        {
            IBinaryIntOperator intOperator = new IntSubtraction();
            Assert.AreEqual(0, intOperator.Operate(1, 1));
        }

        [TestMethod]
        public void AdditionTest()
        {
            IBinaryIntOperator intOperator = new IntAddition();
            Assert.AreEqual(2, intOperator.Operate(1, 1));
        }
    }
}