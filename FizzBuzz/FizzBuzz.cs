using System;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static string fizzBuzzFor(int inputValue)
        {
            var result = "";
            
            if (inputValue % 3 == 0)
            {
                result += "Fizz";
            } 
            if (inputValue % 5 == 0)
            {
                result += "Buzz";
            }

            return result != "" ? result : inputValue.ToString();
        }
    }
}