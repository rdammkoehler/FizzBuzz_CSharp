using System;

namespace FizzBuzz;

public class FizzBuzzGenerator
{
    public static string fizzBuzzFor(int given)
    {
        var result = "";
        if (given % 3 == 0)
        {
            result += "Fizz";
        }

        if (given % 5 == 0)
        {
            result += "Buzz";
        }

        return (result == "") ? given.ToString() : result;
    }
}