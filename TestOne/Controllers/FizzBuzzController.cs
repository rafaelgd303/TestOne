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
        private FizzBuzzService _repository;
        public int pageSize = 20;
    
        public FizzBuzzController(FizzBuzzService fizzBuzzsRepository)
        {
            _repository = fizzBuzzsRepository;
        }
        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            var list = _repository.GetList()?.ToList() ?? new List<FizzBuzz>();
            var model = new BuzzViewModel();
            model.List = list.Skip((id - 1) * pageSize).Take(pageSize).ToList();
            model.Page = id;
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
            return View(fizzBuzz);
        }
    }
}