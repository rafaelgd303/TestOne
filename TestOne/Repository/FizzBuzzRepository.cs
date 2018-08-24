using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestOne.Controllers;
using TestOne.Interfaces;
using TestOne.Models;

namespace TestOne.Repository
{
    public class FizzBuzzRepository : IFizzBuzzRepository
    {
        public static List<FizzBuzz> _fizzBuzzs = new List<FizzBuzz>();
        //{
        //    new FizzBuzz { Text = "1", Color = "regular" },
        //    new FizzBuzz { Text = "2", Color = "regular" },
        //    new FizzBuzz { Text = "3" },
        //    new FizzBuzz { Text = "4" },
        //    new FizzBuzz { Text = "5" },
        //    new FizzBuzz { Text = "6" },
        //    new FizzBuzz { Text = "7" },
        //    new FizzBuzz { Text = "8" },
        //    new FizzBuzz { Text = "9" },
        //    new FizzBuzz { Text = "10" }
        //};

        public void AddFizzBuzz(List<FizzBuzz> fizzBuzz)
        {
             HttpContext.Current.Session["fizzBuzz"] = fizzBuzz;
        }

        public List<FizzBuzz> GetFizzBuzzs()
        {
            return (List<FizzBuzz>) HttpContext.Current.Session["fizzBuzz"];
        }
    }
}