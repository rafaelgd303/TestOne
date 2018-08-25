using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestOne.Services;

namespace TestOne.Controllers
{
    public class FizzBuzzAPIController : ApiController
    {

        public FizzBuzzService fizzBuzzApi { get; set; }

        public FizzBuzzAPIController(FizzBuzzService fizzBuzzsRepository)
        {
            fizzBuzzApi = fizzBuzzsRepository;
        }

        public FizzBuzzService FizzBuzzsRepository { get; }

        // GET: api/FizzBuzzAPI
        public IEnumerable<string> Get()
        {
            return fizzBuzzApi.GetList().Select(fizzbuz => fizzbuz.Text)?.ToList();
        }

        // POST: api/FizzBuzzAPI
        public void Post([FromBody]int range)
        {
            fizzBuzzApi.SetCount(range).ToList();
        }

    }
}
