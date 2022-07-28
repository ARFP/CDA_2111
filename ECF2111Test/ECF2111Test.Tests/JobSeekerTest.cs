using ECF2111Test.Lib;
using ECF2111Test.Lib.Validation;

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

        [TestMethod]
        public void Test_copy()
        {
            JobSeekerAddViewModel j1 = new JobSeekerAddViewModel()
            {
                Name = "Toto"
            };

            JobSeeker j2 = new JobSeeker(j1);

            Assert.AreEqual(j1.Name, j2.Name);
            Assert.AreEqual(j1.Firstname, j2.Firstname);
            Assert.AreEqual(j1.RegistrationYear, j2.RegistrationYear);
            Assert.AreEqual(j1.Level, j2.Level);
            Assert.AreEqual(j1.LastDiplomaName, j2.LastDiplomaName);
            Assert.AreEqual(j1.LastDiplomaYear, j2.LastDiplomaYear);
            Assert.AreEqual(j2.Id, j1.Id);
            Assert.AreEqual(j1.Id, j2.Id);
        }

        /*
         TODO : 
            Tester un modèle JobSeeker et le valider (avec des données valides)
            Tester un modèle JobSeeker et le valider (avec des données invalides)
         */
    }
}