using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public interface IRepository
    {
        IEnumerable<Part> Parts { get; }
        Part GetPart(int key);
        void AddPart(Part part);
        void UpdatePart(Part part);
        void DeletePart(Part part);
    }
}
