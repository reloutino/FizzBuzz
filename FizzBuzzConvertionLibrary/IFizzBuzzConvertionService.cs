using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConvertionLibrary
{
    // in case we want to allow dependancy injection in the main program
    public interface IFizzBuzzConvertionService
    {
        string Convert(int input);
    }
}
