using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOne.Models;

namespace TestOne.Interfaces
{
    public interface IFizzBuzzService
    {
        IEnumerable<FizzBuzz> GetList();
        IEnumerable<FizzBuzz> SetCount(int range);
    }
}