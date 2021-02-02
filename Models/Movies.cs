using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment3.Models
{
    public class Movies
    {
        [Required]
        public String Category { get; set; }

        [Required]
        [TitleValidation]
        public String Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public String Year { get; set; }

        [Required]
        public String Director { get; set; }

        [Required]
        public String Rating { get; set; }

        public Boolean Edited { get; set; }

        public String LentTo { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(25)]
        public String Notes { get; set; }
    }
}
