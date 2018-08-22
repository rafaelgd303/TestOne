using System.ComponentModel.DataAnnotations;

namespace TestOne.Controllers
{
    public class BuzzViewModel
    {
        [Range(1, 1000)]
        public int Range { get; set; }

    }
}