namespace ECF_UNTEL_EXAMPLE.Domain.Models
{
    public class Family
    {
        public int FamilyId { get; set; }
        public string FamilyName { get; set; }
        public Architecture Arch { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Arch.ToString(), FamilyName);
        }
    }
}