using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestOne.Interfaces;
using TestOne.Models;

namespace TestOne.Services
{
    public class FizzBuzzService
    {
        private readonly IFizzBuzzRepository fizzBuzzRepository;

        public FizzBuzzService(IFizzBuzzRepository fizzBuzzRepository)
        {
            this.fizzBuzzRepository = fizzBuzzRepository;
        }

        //public BuzzViewModel SetCount(BuzzViewModel number)
        //{
        //    var list = new List<FizzBuzz>();
        //    for (int i = 1; i < number.Range; i++)
        //    {
        //        if(i % 3 == 0 && i % 5 == 0)
        //        {

        //        }
        //        else if(i % 3 == 0)
        //        {

        //        }
        //        else if(i % 5 == 0)
        //        {

        //        }
        //        else
        //        {

        //        }
        //        list.Add
        //    }   
        //}

        public IEnumerable<FizzBuzz> SetCount(int range)
        {
            DateTime dt = DateTime.Now;
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                var listWednesday = new List<FizzBuzz>();
                return listWednesday;
            }

            var list = new List<FizzBuzz>();
            var fizzbuzz = new FizzBuzz();
            for (int i = 1; i <= range; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzz.Text = "fizz buzz";
                    fizzbuzz.Color = "regular";
                    //list.Add(fizzbuzz);
                }
                else if (i % 3 == 0)
                {
                    fizzbuzz.Text = "fizz";
                    fizzbuzz.Color = "blue";
                    //list.Add(fizzbuzz);
                }
                else if (i % 5 == 0)
                {
                    fizzbuzz.Text = "buzz";
                    fizzbuzz.Color = "green";
                    //list.Add(fizzbuzz);
                }
                else
                {
                    fizzbuzz.Text = i.ToString();
                    fizzbuzz.Color = "regular";
                    //list.Add(fizzbuzz);
                }
                list.Add(fizzbuzz);
            };
            return list;
        }
    }
}