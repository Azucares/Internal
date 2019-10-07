using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AOAdata.Models;
using AOAdata.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AOAdata.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private IPartsInvRepository invRepository;

        public HomeController(IRepository repo, IPartsInvRepository invRepo)
        {
            repository = repo;
            invRepository = invRepo;
        }

        public IActionResult Index()
        {
            var invModel = new PartsInvViewModel();
            invModel.Parts = repository.Parts;
            invModel.inventories = invRepository.inventories;
            return View(invModel);
        }

        public IActionResult UpdatePart(int key)
        {
            return View(repository.GetPart(key));
        }

        [HttpPost]
        public IActionResult UpdatePart(Part part)
        {
            repository.UpdatePart(part);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult AddPart(Part part)
        {
            repository.AddPart(part);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeletePart(Part part)
        {
            repository.DeletePart(part);
            return RedirectToAction(nameof(Index));
        }
    }
}