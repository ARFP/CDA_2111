using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ECF2111Test.Lib
{
    public enum Levels
    {
        [Display(Name = "Sans diplôme", ShortName = "Toto")]
        InfBac = 30,
        Bac = 40,
        BacPlus1 = 50,
        BacPlus2 = 60,
        BacPlus3 = 70,
        BacPlus4 = 80,
        BacPlus5 = 90,
        SupBacPlus5 = 100
    }
}