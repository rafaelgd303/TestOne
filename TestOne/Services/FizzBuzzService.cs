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
            var list = new List<FizzBuzz>();
            var fizzbuzz = new FizzBuzz();
            for (int i = 0; i < range; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzz.Text = "fizz buzz";
                    fizzbuzz.Color = "regular";
                    fizzBuzzRepository.AddFizzBuzz(fizzbuzz);
                }
                else if (i % 3 == 0)
                {
                    fizzbuzz.Text = "fizz";
                    fizzbuzz.Color = "blue";
                    fizzBuzzRepository.AddFizzBuzz(fizzbuzz);
                }
                else if (i % 5 == 0)
                {
                    fizzbuzz.Text = "buzz";
                    fizzbuzz.Color = "green";
                    fizzBuzzRepository.AddFizzBuzz(fizzbuzz);
                }
                else
                {
                    fizzbuzz.Text = range.ToString();
                    fizzbuzz.Color = "regular";
                    fizzBuzzRepository.AddFizzBuzz(fizzbuzz);
                }

                list.Add(fizzbuzz);
            };
            return list;
        }
    }
}