using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MIST.Models
{
    public class Game
    {
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$",
         ErrorMessage = "Please enter a valid Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Cover Image")]
        public string CoverImageName { get; set; }

        [Display(Name = "Media")]
        public string MediaName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$",
         ErrorMessage = "Please enter a valid Genre")]
        public string Genre { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Required]
        [StringLength(9)]
        [Display(Name = "File Type")]
        public string FileType { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$",
         ErrorMessage = "Please enter a valid Device")]
        [Required]
        [StringLength(20)]
        public string Device { get; set; }

        //[RegularExpression(@"^[a-zA-Z\s]*$",
        // ErrorMessage = "Please enter valid text")]
        //[Required]
        //[StringLength(250)]
        public string Description { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$",
        ErrorMessage = "Please enter a valid Developer Name")]
        [Required]
        [StringLength(50)]
        public string Developer { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$",
        ErrorMessage = "Please enter a valid Publisher Name")]
        [Required]
        [StringLength(50)]
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

