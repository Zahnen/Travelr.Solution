using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string CityName { get; set; }
    public string Country { get; set; }
    public string Review { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
    public int Rating { get; set; }
  }
}