using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AOAdata.Models;
using Microsoft.AspNetCore.Mvc;

namespace AOAdata.Controllers
{
    public class PartsInvController : Controller
    {
        private IPartsInvRepository repository;

        public PartsInvController(IPartsInvRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public bool StillInStock(int quan)
        {
            if (quan <= 0)
                return false;
            return true;
        }

        [HttpPost]
        public IActionResult AddPartsInv(PartsInventory partsInv)
        {
            repository.AddInv(partsInv);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult UpdatePartsInv(PartsInventory partsInv)
        {
            if (StillInStock(partsInv.Quantity))
                repository.UpdateInv(partsInv);
            else
                repository.DeleteInv(partsInv);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeletePartsInv(PartsInventory partsInv)
        {
            repository.DeleteInv(partsInv);
            return RedirectToAction("Index", "Home");
        }
    }
}