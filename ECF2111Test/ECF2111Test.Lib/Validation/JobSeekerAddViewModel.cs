using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ECF2111Test.Lib.Validation
{
    public class JobSeekerAddViewModel : JobSeeker 
    {
        private readonly Regex regexNames = new Regex(@"^[a-zA-Z]+(?:\s[a-zA-Z]+)*$");

        private readonly Regex regexDiploma = new Regex(@"^[^\?<>]+$");

        public JobSeekerAddViewModel() { }

        public bool IsValid()
        {
            RegistrationYear = DateTime.Now.Year;

            if (IsValidName() && IsValidFirstName() && IsValidDiplomaName())
            {
                if (LastDiplomaYear != null && String.IsNullOrEmpty(LastDiplomaName))
                {
                    throw new InvalidDataException("Le nom du diplôme est requis si l'année est précisée");
                }
                if(LastDiplomaYear is null && !String.IsNullOrEmpty(LastDiplomaName))
                {
                    throw new InvalidDataException("La date du diplôme est requise si le nom est précisé");
                }

                return true;
            }

            return false;

        }

        public bool IsValidName()
        {
            return regexNames.IsMatch(Name);
        }

        public bool IsValidFirstName()
        {
            return regexNames.IsMatch(Firstname);
        }

        public bool IsValidLastDiplomaYear()
        {
            return (LastDiplomaYear > RegistrationYear - 60 && LastDiplomaYear < RegistrationYear + 2);
        }

        public bool IsValidDiplomaName()
        {
            return String.IsNullOrEmpty(LastDiplomaName) || regexDiploma.IsMatch(LastDiplomaName);
        }

    }
}
