﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SailorWebServer.Models.Entities;

public class CategoryModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } 
    
    public string Name { get; set; }
    
    public string Slug { get; set; }

    public List<PostModel> Posts { get; set; } = new ();

}