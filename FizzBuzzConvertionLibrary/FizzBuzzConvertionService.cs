using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConvertionLibrary
{
    public class FizzBuzzConvertionService : IFizzBuzzConvertionService
    {
        public string Convert(int input)
        {
            var isMultipleOf3 = input % 3 == 0;
            var isMultipleOf5 = input % 5 == 0;

            // of course the "else" and test on negative values of bools are not necessary
            // but they reduce the risk of errors in further evolution and merges
            if(isMultipleOf3 && isMultipleOf5)
            {
                return "FizzBuzz";
            }
            else if (isMultipleOf3 && !isMultipleOf5)
            {
                return "Fizz";
            }
            else if (!isMultipleOf3 && isMultipleOf5)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
