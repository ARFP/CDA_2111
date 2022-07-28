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



        public bool IsValid()
        {
            if(!regexNames.IsMatch(Name) || !regexNames.IsMatch(Firstname))
            {
                return false;
            }

            if(!regexDiploma.IsMatch(LastDiplomaName))
            {
                return false;
            }

            RegistrationYear = DateTime.Now.Year;


            if(LastDiplomaYear < RegistrationYear-60 || LastDiplomaYear > RegistrationYear+2)
            {
                return false;
            }


            return true;
        }
        
    }
}
