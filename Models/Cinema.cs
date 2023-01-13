using System.ComponentModel.DataAnnotations;

namespace ProjectMidTerm.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Full Name")]
        public string FullName { get; set; }

        [Display(Name="Description")]
        public string Description  { get; set; }

        [Display(Name="Logo")]
        public string Logo { get; set; }

    }
}
