using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;
        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetBooks());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _repository.CreateBook(model);

            return RedirectToAction("Index");
        }
    }
}
