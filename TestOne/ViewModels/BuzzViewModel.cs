using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestOne.Models
{
    public class BuzzViewModel
    {
        [Range(1, 1000)]
        public int Range { get; set; }

        public List<FizzBuzz> List { get; set; } = new List<FizzBuzz>();

    }
}