using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MIST.Models
{
    public class Game
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Cover Image")]
        public string CoverImageName { get; set; }

        [Display(Name = "Media")]
        public string MediaName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(15)]
        public string Genre { get; set; }
        
        [StringLength(9)]
        [Required]
        [Display(Name = "File Type")]
        public string FileType { get; set; }

        [StringLength(20)]
        [Required]
        public string Device { get; set; }

        [StringLength(250)]
        [Required]
        public string Description { get; set; }

        [StringLength(50)]
        [Required]
        public string Developer { get; set; }

        [StringLength(50)]
        [Required]
        public string Publisher { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0,999.99)]
        public decimal Price { get; set; }

        public static implicit operator Game(int? v)
        {
            throw new NotImplementedException();
        }
    }
}

