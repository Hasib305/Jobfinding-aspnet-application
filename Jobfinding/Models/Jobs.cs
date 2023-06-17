﻿using System.ComponentModel.DataAnnotations;

namespace Jobfinding.Models
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Job Catagories")]
        public string ImageURL { get; set; }
        [Display(Name = "Logo")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Info  { get; set; }
        
        public List<Findjobs>Findjobs { get; set; }
    }
}