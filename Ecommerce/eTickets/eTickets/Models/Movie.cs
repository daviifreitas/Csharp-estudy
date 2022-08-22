using System.ComponentModel.DataAnnotations;
using eTickets.Data.Enuns;

namespace eTickets.Models
{
    public class Movie
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        #endregion

        #region Relationship

        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }

        #endregion
    }
}
