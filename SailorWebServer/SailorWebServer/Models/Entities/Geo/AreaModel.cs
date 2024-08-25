using System.ComponentModel.DataAnnotations.Schema;

namespace SailorWebServer.Models.Entities.Geo;

public class AreaModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }

    public List<CityModel> Cities { get; set; } = new List<CityModel>();

}