using System.ComponentModel.DataAnnotations;
using ParksApi.Models;
using System.Collections.Generic;

namespace ParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }
  }
}