﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanUI.Models
{
    public class Periodicity
    {
        public string Name { get; set; }
        public int HowManyMonths { get; set; }

        public Periodicity(string _name, int _howManyMonths)
        {
            Name = _name;
            HowManyMonths = _howManyMonths;
        }

        override public string ToString()
        {
            return Name;
        }
    }
}
 