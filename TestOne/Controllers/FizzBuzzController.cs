using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOne.Interfaces;
using TestOne.Models;
using TestOne.Services;

namespace TestOne.Controllers
{
    public class FizzBuzzController : Controller
    {
        private FizzBuzzService _repository;
    
        public FizzBuzzController(FizzBuzzService fizzBuzzsRepository)
        {
            _repository = fizzBuzzsRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new BuzzViewModel());
        }

        [HttpPost]
        public ActionResult Index(BuzzViewModel fizzBuzz)
        {
            if (ModelState.IsValid)
            {
                fizzBuzz.List = _repository.SetCount(fizzBuzz.Range).ToList();
                //fizzBuzz.List.Skip(150).Take(20).ToList();
            }
            return View(fizzBuzz);
        }
    }
}