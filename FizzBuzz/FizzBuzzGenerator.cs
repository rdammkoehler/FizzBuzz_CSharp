using System;

namespace FizzBuzz;

public class FizzBuzzGenerator
{
    public static string fizzBuzzFor(int given)
    {
        if (given % 3 == 0 && given % 5 == 0)
        {
            return "FizzBuzz";
        }

        if (given % 3 == 0)
        {
            return "Fizz";
        }

        if (given % 5 == 0)
        {
            return "Buzz";
        }

        return given.ToString();
    }
}