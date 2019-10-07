using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public interface IPartsInvRepository
    {
        IEnumerable<PartsInventory> inventories { get; }
        void AddInv(PartsInventory partsInv);
        void UpdateInv(PartsInventory partsInv);
        void DeleteInv(PartsInventory partsInv);
    }

    public class PartsInvRepository : IPartsInvRepository
    {
        private AOAContext context;

        public IEnumerable<PartsInventory> inventories => context.PartsInventory;
        public PartsInventory GetInv(int key) => context.PartsInventory.Find(key);

        public PartsInvRepository(AOAContext ctx)
        {
            context = ctx;
        }

        public void AddInv(PartsInventory partsInv)
        {
            context.PartsInventory.Add(partsInv);
            context.SaveChanges();
        }
        public void UpdateInv(PartsInventory partsInv)
        {
            context.PartsInventory.Update(partsInv);
            context.SaveChanges();
        }
        public void DeleteInv(PartsInventory partsInv)
        {
            context.PartsInventory.Remove(partsInv);
            context.SaveChanges();
        }

    }
}
