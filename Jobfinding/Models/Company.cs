using System.ComponentModel.DataAnnotations;

namespace Jobfinding.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Companylogo")]
        public string ImageURL { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Detail")]
        public string Info { get; set; }
        public List<Findjobs>findjobs { get; set; }
    }
}

