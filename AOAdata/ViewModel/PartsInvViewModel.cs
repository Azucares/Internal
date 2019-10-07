using AOAdata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.ViewModel
{
    public class PartsInvViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public IEnumerable<PartsInventory> inventories { get; set; }

        public List<PartsInventory> matchInv(int partId)
        {
            List<PartsInventory> matched = new List<PartsInventory>();
            foreach(PartsInventory i in inventories)
            {
                if (partId == i.Part.Id)
                    matched.Add(i);
            }
            return matched;
        }
    }
}
