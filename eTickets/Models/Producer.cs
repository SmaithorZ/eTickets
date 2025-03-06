using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "You must add a Profile Picture!")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "You must add a name!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 50 chars")]


        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "You must add a biography!")]

        public string Bio { get; set; }


        //Relationships

        public List<Movie> Movies { get; set; }

    }
}
