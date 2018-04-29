using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DbModels
{
    public class Director
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something is wrong with Name !")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something is wrong with Surname !")]
        public string Surname { get; set; }

        [StringLength(800, MinimumLength = 10, ErrorMessage = "Something is wrong with Biography !")]
        public string Biography { get; set; }

    }
}
