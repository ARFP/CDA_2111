using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ECF2111Test.Lib 
{
    public class JobSeeker
    {
        private static int lastId = 0;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int RegistrationYear { get; set; }

        public Levels Level { get; set; }

        public string? LastDiplomaName { get; set; }

        public int? LastDiplomaYear { get; set; }

        public string Employability {  get { return Level + "%";  } }


        public JobSeeker()
        {
            Id = ++lastId;
        }

        public JobSeeker(JobSeeker other)
        {
            Id = other.Id;
            Name = other.Name;
            Firstname = other.Firstname;
            RegistrationYear = other.RegistrationYear;
            Level = other.Level;
            LastDiplomaName = other.LastDiplomaName;
            LastDiplomaYear = other.LastDiplomaYear;
        }
    }
}