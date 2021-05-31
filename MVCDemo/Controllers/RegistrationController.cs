using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AgeCalculationService ageCalculationService;

        public RegistrationController()
        {
            this.ageCalculationService = new AgeCalculationService();
        }

        public IActionResult Index()
        {
            var model = new RegistrationModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Post(RegistrationModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            model.BirthDate = this.ageCalculationService.CalculateBirthDateFromAge(model.Age);

            return View(model);
        }
    }
}
