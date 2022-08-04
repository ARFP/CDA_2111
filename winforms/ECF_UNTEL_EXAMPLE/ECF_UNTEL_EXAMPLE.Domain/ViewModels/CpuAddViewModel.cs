using ECF_UNTEL_EXAMPLE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECF_UNTEL_EXAMPLE.Domain.ViewModels
{
    public class CpuAddViewModel
    {
        static Regex rgxRef = new Regex("^[0-9]{4}[A-Z]{1}$");
        static Regex rgxLetters = new Regex("^[a-zA-Z]+$");

        public Cpu Cpu { get; private set; }

        public string Errors { get; private set; }

        public CpuAddViewModel(Cpu _cpu)
        {
            Cpu = _cpu;
            Errors = String.Empty;
        }

        public bool IsValid()
        {
            StringBuilder error = new StringBuilder();

            if(DomainData.Cpus.FirstOrDefault(x => x.Reference == this.Cpu.Reference) != null)
            {
                error.AppendLine("La Référence CPU existe déjà !");
            }

            if(!rgxRef.IsMatch(Cpu.Reference))
            {
                error.AppendLine("Le format de la référence du CPU est incorrect");
            }

            if(!rgxLetters.IsMatch(Cpu.Name))
            {
                error.AppendLine("Le format du nom du CPU est incorrect");
            }

            if(Cpu.Family is null || Cpu.Family.FamilyId < 1000)
            {
                error.AppendLine("La famille sélectionnée est invalide");
            }

            Errors = error.ToString();

            return error.Length < 1;
        }
    }
}
