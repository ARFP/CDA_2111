using ECF2111Test.Lib;

namespace ECF2111Test.Tests
{
    [TestClass]
    public class JobSeekerTest
    {
        [TestMethod]
        public void Test_ID()
        {
            JobSeeker j1 = new JobSeeker();
            JobSeeker j2 = new JobSeeker();

            Assert.AreEqual(1, j1.Id);
            Assert.AreEqual(2, j2.Id);
        }

        /*
         TODO : 
            Tester un modèle JobSeeker et le valider (avec des données valides)
            Tester un modèle JobSeeker et le valider (avec des données invalides)
         */
    }
}