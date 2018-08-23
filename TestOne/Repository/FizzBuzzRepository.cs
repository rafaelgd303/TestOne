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
        public static List<FizzBuzz> _fizzBuzzs = new List<FizzBuzz>
        {
            new FizzBuzz { Text = "1" },
            new FizzBuzz { Text = "2" },
            new FizzBuzz { Text = "3" },
            new FizzBuzz { Text = "4" },
            new FizzBuzz { Text = "5" },
            new FizzBuzz { Text = "6" },
            new FizzBuzz { Text = "7" },
            new FizzBuzz { Text = "8" },
            new FizzBuzz { Text = "9" },
            new FizzBuzz { Text = "10" }
        };

        public void AddFizzBuzz(FizzBuzz fizzBuzz)
        {
            //HttpCurrentSession
            //HttpContext.Current.Session
            
            HttpContext context = HttpContext.Current;
            context.Session["fizzBuzz"] = fizzBuzz;
                //save to repo for paging 
            _fizzBuzzs.Add(fizzBuzz);
        }

        public List<FizzBuzz> GetFizzBuzzs()
        {
            return _fizzBuzzs;
        }
    }
}