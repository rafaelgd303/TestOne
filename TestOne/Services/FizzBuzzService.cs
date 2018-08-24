using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestOne.Interfaces;
using TestOne.Models;

namespace TestOne.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzRepository fizzBuzzRepository;

        public FizzBuzzService(IFizzBuzzRepository fizzBuzzRepository)
        {
            this.fizzBuzzRepository = fizzBuzzRepository;
        }

        public IEnumerable<FizzBuzz> GetList()
        {
            return this.fizzBuzzRepository.GetFizzBuzzs();
        }

        public IEnumerable<FizzBuzz> SetCount(int range)
        {
            DateTime dt = DateTime.Now;
            string fizz = "fizz";
            string buzz = "buzz";
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                fizz = "wizz";
                buzz = "wuzz";
            }

            var list = new List<FizzBuzz>();
            for (int i = 1; i <= range; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add(new FizzBuzz() { Text = fizz + " " + buzz, Color = "regular" });
                }
                else if (i % 3 == 0)
                {
                    list.Add(new FizzBuzz() { Text = fizz, Color = "blue" });
                }
                else if (i % 5 == 0)
                {
                    list.Add(new FizzBuzz() { Text = buzz, Color = "green" });
                }
                else
                {
                    list.Add(new FizzBuzz() { Text = i.ToString(), Color = "regular" });
                }
            };

            this.fizzBuzzRepository.AddFizzBuzz(list);
            return list;
        }
    }
}