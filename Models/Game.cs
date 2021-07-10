using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MIST.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Cover Image")]
        public string CoverImageName { get; set; }

        [Display(Name = "Media")]
        public string MediaName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Display(Name = "File Type")]
        public string FileType { get; set; }
        public string Device { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

