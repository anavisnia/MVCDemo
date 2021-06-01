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
        private readonly AgeCalculationService _ageCalculationService;

        // dependency injection
        public RegistrationController(AgeCalculationService ageCalculationService)
        {
            _ageCalculationService = ageCalculationService ?? throw new ArgumentNullException(nameof(ageCalculationService));
        }

        //public RegistrationController()
        //{
        //    _ageCalculationService = new AgeCalculationService();
        //}

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

            model.BirthDate = _ageCalculationService.CalculateBirthDateFromAge(model.Age);

            return View(model);
        }
    }
}
