using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestOne.Models
{
    public class BuzzViewModel
    {
        [Range(1, 1000)]
        [Display(Name="Add value")]
        public int Range { get; set; }
        public List<FizzBuzz> List { get; set; } = new List<FizzBuzz>();

        public int Page { get; set; }
        public int MaxPage { get; set; }
        public bool Previous { get; set; }
        public bool Next { get; set; }
    }
}