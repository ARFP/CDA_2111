namespace ToutEmbalDemo.Tests
{
    [TestClass]
    public class ProductionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Production production = new Production(TypeDeCaisse.A,5000);

            Assert.AreEqual(TypeDeCaisse.A, production.caisse);

            Assert.AreEqual(0, production.CompteurProduction);

            production.Demarrer();

            Assert.AreEqual(5000, production.CompteurProduction);

            production.Arreter();
        }

        [TestMethod]
        public void Test_Thread()
        {

            Production p = new Production(TypeDeCaisse.A, 10000);

            Thread t = new Thread(p.Executer);

            t.Start();

            Assert.AreEqual(5000, p.CompteurProduction);
        }

    }
}