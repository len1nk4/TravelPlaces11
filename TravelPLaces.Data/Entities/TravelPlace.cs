using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPLaces11.Data.Entities
{
    public class TravelPlace
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Area { get; set; }

        [Required]
        public string Type { get; set; }

        [Range(0, double.MaxValue, ErrorMessage ="Входната такса не може да бъде отрицателна.")]
        public decimal Fee { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }


    }
}
