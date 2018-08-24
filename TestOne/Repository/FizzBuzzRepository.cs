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

        public void AddFizzBuzz(List<FizzBuzz> fizzBuzz)
        {
             HttpContext.Current.Session["fizzBuzz"] = fizzBuzz;
        }

        public List<FizzBuzz> GetFizzBuzzs()
        {
            return (List<FizzBuzz>)HttpContext.Current.Session["fizzBuzz"];
        }
    }
}