using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.DbModels
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title of the movie is required !")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "PicturePath is required !")]
        public string PicturePath { get; set; }

        [Required(ErrorMessage = "Something is wrong with Duration")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Something is wrong with Date")]
        public int RealeseDate { get; set; }

        [Required(ErrorMessage = "Something is wrong with Raiting")]
        public int Raiting { get; set; }

        [Required(ErrorMessage = "Something is wrong with Free Access")]
        public bool Free { get; set; }

        [Required]
        [StringLength(1500, MinimumLength = 10, ErrorMessage = "Something is wrong with MovieDescription !")]
        public string Description { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Something is wrong with Genre1 !")]
        public string Genre1 { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Something is wrong with Genre2 !")]
        public string Genre2 { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Something is wrong with Genre3 !")]
        public string Genre3 { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something is wrong with MoviePath !")]
        public string MoviePath { get; set; }

        public byte DirectorId { get; set; }

        //[ForeignKey("DirectorId")]
        public Director Director { get; set; }

        public byte CountryId { get; set; }

        //[ForeignKey("CountryId")]
        public Country Country { get; set; }

        public byte LanguageId { get; set; }

        //[ForeignKey("LanguageId")]
        public Language Language { get; set; }

    }
}
