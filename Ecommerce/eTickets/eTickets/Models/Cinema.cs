using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Discription")]
        public string Description { get; set; }

        #endregion

        #region Relationship

        public List<Movie> Movies { get; set; }

        #endregion


    }
}
