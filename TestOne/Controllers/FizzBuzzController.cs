using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOne.Interfaces;
using TestOne.Models;
using TestOne.Services;
using PagedList;

namespace TestOne.Controllers
{
    public class FizzBuzzController : Controller
    {
        private IFizzBuzzService _repository;
        public int pageSize = 20;
    
        public FizzBuzzController(IFizzBuzzService fizzBuzzsRepository)
        {
            _repository = fizzBuzzsRepository;
        }
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            var list = _repository.GetList()?.ToList() ?? new List<FizzBuzz>();
            var model = new BuzzViewModel();
            model.List = list.Skip((id) * pageSize).Take(pageSize).ToList();
            model.Page = id < 0 ? 0 : id;
            model.MaxPage = (int)(list.Count() / pageSize);
            //(int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

            model.Previous = id <= 0 ? true : false;
            model.Next = model.Page >= model.MaxPage;

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(BuzzViewModel fizzBuzz)
        {
            if (ModelState.IsValid)
            {
                fizzBuzz.List = _repository.SetCount(fizzBuzz.Range).ToList();
                fizzBuzz.Page = 1;
            }
            return RedirectToAction("Index", new { @id = 0 });
        }
    }
}