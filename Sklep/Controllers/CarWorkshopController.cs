using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Sklep.Controllers
{
    public class CarWorkshopController : Controller
    {
        public ICarWorkshopServices _carworkshopServices;
        public CarWorkshopController(ICarWorkshopServices carWorkshopServices) 
        {
            _carworkshopServices =carWorkshopServices;

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarWorkshop.Domain.Encje.CarWorkshop  carWorkshop)
        {
               await _carworkshopServices.Create(carWorkshop);
            return RedirectToAction(nameof(Create)); // TO DO REFACTOR   
        }
    }
}
