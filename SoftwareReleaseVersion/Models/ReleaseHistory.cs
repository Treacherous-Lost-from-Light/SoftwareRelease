namespace SoftwareReleaseVersion.Models
{
    public class ReleaseHistory
    {
        public int Id { get; set; }
        public int ReleaseId { get; set; }
        public string Version { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; } = DateTime.Today;
        public Release Release { get; set; } = null!;
    }
}
