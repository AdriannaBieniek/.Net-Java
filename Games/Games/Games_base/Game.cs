using System.ComponentModel.DataAnnotations;

namespace Games.Games_base
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RelaseDate { get; set; }
        public string Genre { get; set; }
        public string Platforms { get; set; }
        public Double Price { get; set; }

    }
}
