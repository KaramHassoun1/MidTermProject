using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMidTerm.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
