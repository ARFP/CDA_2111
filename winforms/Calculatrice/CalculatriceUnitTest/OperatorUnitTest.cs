using CalculatriceCore;

namespace CalculatriceUnitTest
{
    [TestClass]
    public class OperatorUnitTest
    {
        [TestMethod]
        public void IsAdditionCorrect()
        {
            Operator anOperator = new Operator();
            anOperator.AdditionNumber(5);
            anOperator.AdditionNumber(5);
            int result = anOperator.GetResult();

            Assert.AreEqual(result, 10);
        }
    }
}