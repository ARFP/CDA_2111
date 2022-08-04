
namespace ECF_UNTEL_EXAMPLE.Domain.Models
{
    public class Cpu
    {
        public string Reference { get; set; }
        public Family Family { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}
