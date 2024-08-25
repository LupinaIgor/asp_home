using System.ComponentModel.DataAnnotations.Schema;

namespace SailorWebServer.Models.Entities.Geo;

public class StreetModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; } 
    
    public int CityId { get; set; }
    [ForeignKey("CityId")]
    public CityModel City { get; set; }
    
}