namespace SoftwareReleaseVersion.Models
{
    public class ReleaseHistory
    {
        public int Id { get; set; }
        public int ReleaseId { get; set; }
        public Release Release { get; set; } = null!;
    }
}
