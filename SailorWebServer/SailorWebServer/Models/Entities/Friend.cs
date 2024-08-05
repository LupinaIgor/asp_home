using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailorWebServer.Models.Entities;

public class Friend
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    public string Country { get; set; }
    
    [Required]
    public string Email { get; set; }
}