using System;
using System.ComponentModel.DataAnnotations;


namespace MIST.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
    }
}

