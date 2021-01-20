using System.ComponentModel.DataAnnotations;

namespace Travelr.Models
{
  public class Destination
  {
    [Required]
    public int DestinationId { get; set; }
    [Required]
    public string CityName { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
    public int Rating { get; set; }
  }
}