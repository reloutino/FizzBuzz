using FizzBuzzConvertionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private static IFizzBuzzConvertionService ConvertionService;

        static void Main(string[] args)
        {
            ConvertionService = new FizzBuzzConvertionService();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(ConvertionService.Convert(i));
            }
            Console.ReadKey();
        }
    }
}
