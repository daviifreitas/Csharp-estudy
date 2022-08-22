using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [DisplayName("Profile Picture URL")]
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        [DisplayName("Biography")]
        public string Bio { get; set; }

        #endregion


        #region releationships


        public List<Actor_Movie> Actors_Movices { get; set; }

        #endregion


    }
}
