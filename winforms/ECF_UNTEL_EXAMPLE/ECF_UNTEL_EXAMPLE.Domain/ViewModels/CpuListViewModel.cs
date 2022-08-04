using ECF_UNTEL_EXAMPLE.Domain;
using ECF_UNTEL_EXAMPLE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_EXAMPLE.Domain.ViewModels
{
    public  class CpuListViewModel
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public string FamilyName { get; set; }

        public CpuListViewModel(Cpu cpu)
        {
            Reference = cpu.Reference;
            Name = cpu.Name;
            Frequency = cpu.Frequency;
            FamilyName = cpu.Family.FamilyName;
        }
    }
}
