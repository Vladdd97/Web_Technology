using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DbModels
{
    public class Picture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Something is wrong with PictureName !")]
        public string PictureName { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 2, ErrorMessage = "Something is wrong with PicturePath !")]
        public string PicturePath { get; set; }
    }
}
