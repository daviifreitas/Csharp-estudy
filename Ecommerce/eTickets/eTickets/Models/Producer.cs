using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        #region properties

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name ="Full name")]
        public string FullName { get; set; } 
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        #endregion

        #region reletionships

        public List<Movie> Movies { get; set; }

        #endregion

    }
}
