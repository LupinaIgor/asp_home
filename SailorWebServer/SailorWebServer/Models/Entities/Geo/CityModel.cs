using System.ComponentModel.DataAnnotations.Schema;

namespace SailorWebServer.Models.Entities.Geo;

public class CityModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int AreaId { get; set; }
    [ForeignKey("AreaId")]
    public AreaModel Area { get; set; }

    public List<StreetModel> Streets { get; set; } = new List<StreetModel>();

    public List<CityTypeModel> CityTypes { get; set; } = new List<CityTypeModel>();
}