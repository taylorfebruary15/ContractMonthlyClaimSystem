namespace ContractMonthlyClaimSystem.Models
{
    public class SupportingDocument
    {
        public Guid DocumentId { get; set; } = Guid.NewGuid();
        public Guid ClaimId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
    }
}
