using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMdiContainer.Lib
{
    // Code pur car elle n'a pas d'influence (ne modifier pas)
    // avec d'autres classes ou d'autres données
    public class DateValidate
    {
        private DateTime convertDate;

        public DateValidate()
        {
            /* 
             * Non nécessaire car DateTime est une structure
             * du coup pas besoin d'initialiser l'attribut convertDate 
            */
            // convertDate = new DateTime();
        }
        public bool IsValid(string _date)
        {
            try
            {
                convertDate = DateTime.ParseExact(
                    _date,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture
                );

                // 1er méthode
                // Bonne pratique pour récupérer la date d'aujourd'hui
                // return convertDate > DateTime.Now;
                
                // 2eme methode
                if (convertDate <= DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(
                        "La date doit être dans le futur"
                    );
                }

                return true;
            }
            catch (FormatException e)
            {
                // 1er methode
                // return false;

                // 2eme methode
                //e.Message = "Format de la date invalide";
                throw e;
            }         
        }

    }
}
