using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public class PartsInventory
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string CostCode { get; set; }

        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}