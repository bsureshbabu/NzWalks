using System.ComponentModel.DataAnnotations;

namespace NzWalks.API.Models.DTOs
{
    public class AddRegionDto
    {
        [Required,MinLength(1, ErrorMessage = "Code is required"),MaxLength(255)]
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
