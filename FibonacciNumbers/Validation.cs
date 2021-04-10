using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciNumbers
{
    public class Validation
    {
        public static bool ValidateCountOfNumbers(string count)
        {
            try
            {
                int countOfNumbers = int.Parse(count);
                if (countOfNumbers <= 1)
                {
                    return false;
                }
                else if (countOfNumbers >= int.MaxValue)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            
            return true;
        }
    }
}
