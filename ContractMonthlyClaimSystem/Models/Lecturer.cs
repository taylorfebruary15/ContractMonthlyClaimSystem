namespace ContractMonthlyClaimSystem.Models
{
    public class Lecturer
    {
        public Guid LecturerId { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string AccountNumber { get; set; }
    }
}
