using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public class DataRepository : IRepository
    {
        private AOAContext context;

        public DataRepository(AOAContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Part> Parts => context.Parts;
        public Part GetPart(int key) => context.Parts.Find(key);

        public void AddPart(Part part)
        {
            this.context.Parts.Add(part);
            this.context.SaveChanges();
        }
        public void UpdatePart(Part part)
        {
            Part p = GetPart(part.Id);
            p.PartNumber = part.PartNumber;
            p.Name = part.Name;
            p.Location = part.Location;

            //this.context.Parts.Update(part);
            context.SaveChanges();
        }
        public void DeletePart(Part part)
        {
            this.context.Parts.Remove(part);
            this.context.SaveChanges();
        }
    }
}
