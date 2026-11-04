using System.ComponentModel.DataAnnotations;

namespace SoftwareReleaseVersion.Models
    {
        public class Release
        {
            public int Id { get; set; }
            [Required]
            public string Version { get; set; } = string.Empty;
            [Required]
            public string Description { get; set; } = string.Empty;

            public string Status { get; set; } = "In Development";

            public DateTime ReleaseDate { get; set; } = DateTime.Today;
        }
    }
