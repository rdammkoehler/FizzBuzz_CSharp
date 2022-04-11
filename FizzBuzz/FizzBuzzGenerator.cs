using System.IO;

namespace FizzBuzz;

public class FizzBuzzGenerator
{
    private readonly TextWriter writer;
    
    public FizzBuzzGenerator(TextWriter writer)
    {
        this.writer = writer;
    }

    public void play()
    {
        for (int idx = 1; idx < 101; idx++)
        {
            writer.WriteLine(fizzBuzzFor(idx));
        }
    }
    
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