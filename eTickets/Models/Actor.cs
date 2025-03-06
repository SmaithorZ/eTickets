using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Please add an Image URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 50 chars")]
        [Required(ErrorMessage = "Full Name is Required!")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required!")]

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}
