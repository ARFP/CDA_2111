using ECF_UNTEL_EXAMPLE.Domain.Models;
using ECF_UNTEL_EXAMPLE.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_UNTEL_EXAMPLE.Domain
{
    public  class DomainData
    {
        public static List<CpuListViewModel> CpuList = new List<CpuListViewModel>();


        public static List<Family> Families = new List<Family>()
        {
            new Family() { FamilyId = 1001, FamilyName = "LAKE", Arch = Architecture.x86},
            new Family() { FamilyId = 1002, FamilyName = "LAKE", Arch = Architecture.x64},
            new Family() { FamilyId = 2001, FamilyName = "SUMO", Arch = Architecture.x64},
        };

        public static List<Cpu> Cpus = new List<Cpu>()
        {
            new Cpu() {
                Reference = "1200F",
                Name = "Kakao",
                Frequency = 2.700,
                ReleaseDate = DateTime.Parse("2018-05-02"),
                Price = 99,
                Family = Families[0]
            },
            new Cpu() {
                Reference = "5600X",
                Name = "ProLiner",
                Frequency = 3.200,
                ReleaseDate = DateTime.Parse("2019-09-12"),
                Price = 189,
                Family = Families[1]
            },
            new Cpu() {
                Reference = "8000X",
                Name = "SayPlusPlus",
                Frequency = 4.333,
                ReleaseDate = DateTime.Parse("2021-11-12"),
                Price = 439,
                Family = Families[2]
            },
        };

        public static void Load()
        {
            CpuList.Clear();

            foreach (Cpu cpu in Cpus)
            {
                CpuList.Add(new CpuListViewModel(cpu));
            }
        }
    }
}
