using LibValidationSaisie;

namespace TestValidationSaisie
{
    [TestClass]
    public class TestValidation
    {

        [TestMethod]
        public void TestValidationName()
        {
            NameValidate nameValidate = new NameValidate();
            string test = "toto";
            bool resultTest = nameValidate.IsValid(test);
            Assert.IsTrue(resultTest);
            Assert.AreEqual(true, resultTest);
            Assert.IsTrue(nameValidate.IsValid("jean-toto"));
        }

        [TestMethod]
        public void TestInvalidName()
        {
            NameValidate nameValidate = new NameValidate();
            string test = "toto#007";
            bool resultTest = nameValidate.IsValid(test);
            Assert.AreEqual(false, resultTest);

            Assert.IsFalse(nameValidate.IsValid("toto#007"));
            Assert.IsFalse(nameValidate.IsValid("toto  "));
            Assert.IsFalse(nameValidate.IsValid(""));
            Assert.IsFalse(nameValidate.IsValid("toto--tata"));
        }

        [TestMethod]
        public void TestValidDate()
        {
            DateValidate dateValidate = new DateValidate();

            Assert.IsTrue(dateValidate.IsValid(
                DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")),
                "La date est dans le futur"
            );
        }

        [TestMethod]
        public void TestInvalidDateNow()
        {
            DateValidate dateValidate = new DateValidate();

            try
            {
                dateValidate.IsValid(DateTime.Now.ToString("dd/MM/yyyy"));
                //dateValidate.IsValid(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));
                //dateValidate.IsValid(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));

                Assert.Fail("La date est dans le passé ou à la date d'aujourd'hui");
            }
            catch(ArgumentOutOfRangeException)
            {
                // La date est incorrecte car elle correspond à maintenant
                // du coup le test d'echec est correct
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestInvalidDateFormat()
        {
            DateValidate dateValidate = new DateValidate();

            try
            {
                string invalideFormatDate = DateTime.Now.AddDays(1).ToString("yyyy/dd/MM");
                dateValidate.IsValid(invalideFormatDate);

                Assert.Fail(
                    String.Format(
                        "La date n'est pas correctement formatée {0} au lieu de dd/MM/yyyy",
                        invalideFormatDate
                    )
                );
            }
            catch(FormatException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}