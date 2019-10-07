using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public class Part
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PartNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
