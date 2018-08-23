using System.Collections.Generic;
using TestOne.Models;

namespace TestOne.Interfaces
{
    public interface IFizzBuzzRepository
    {
        List<FizzBuzz> GetFizzBuzzs();
        void AddFizzBuzz(FizzBuzz fizzBuzz);
    }
}