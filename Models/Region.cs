using System.ComponentModel.DataAnnotations;

namespace ServerGame106.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}