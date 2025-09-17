namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public Guid ClaimId { get; set; } = Guid.NewGuid();
        public Guid LecturerId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalAmount => HoursWorked * HourlyRate;
        public ClaimStatus Status { get; set; } = ClaimStatus.Approved;
    }
}
