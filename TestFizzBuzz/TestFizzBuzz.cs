using System.IO;
using FizzBuzz;

namespace TestFizzBuzz;

using Xunit;

public class TestFizzBuzz
{
    [Fact]
    public void TestFizzBuzzGivenOneReturnsOne()
    {
        Assert.Equal("1", FizzBuzzGenerator.fizzBuzzFor(1));
    }

    [Fact]
    public void TestFizzBuzzGivenTwoReturnsTwo()
    {
        Assert.Equal("2", FizzBuzzGenerator.fizzBuzzFor(2));
    }

    [Fact]
    public void TestFizzBuzzGivenThreeReturnsFizz()
    {
        Assert.Equal("Fizz", FizzBuzzGenerator.fizzBuzzFor(3));
    }

    [Fact]
    public void TestFizzBuzzGivenSixReturnsFizz()
    {
        Assert.Equal("Fizz", FizzBuzzGenerator.fizzBuzzFor(6));
    }

    [Fact]
    public void TestFizzBuzzGivenFiveReturnsBuzz()
    {
        Assert.Equal("Buzz", FizzBuzzGenerator.fizzBuzzFor(5));
    }

    [Fact]
    public void TestFizzBuzzGivenTenReturnsBuzz()
    {
        Assert.Equal("Buzz", FizzBuzzGenerator.fizzBuzzFor(10));
    }

    [Fact]
    public void TestFizzBuzzGivenFifteenReturnsFizzBuzz()
    {
        Assert.Equal("FizzBuzz", FizzBuzzGenerator.fizzBuzzFor(15));
    }

    [Fact]
    public void TestFizzBuzzGivenThirtyReturnsFizzBuzz()
    {
        Assert.Equal("FizzBuzz", FizzBuzzGenerator.fizzBuzzFor(30));
    }

    [Fact]
    public void TestFizzBuzzReturnsOneOnTheFirstIteration()
    {
        TextWriter writer = new StringWriter();
        
        new FizzBuzzGenerator(writer).play();
        
        string[] output = WriterToArray(writer);
        Assert.Equal("1", output[0]);
    }

    [Fact]
    public void TestFizzBuzzReturnsTwentyThreeOnTheTwentyThirdIteration()
    {
        TextWriter writer = new StringWriter();
        
        new FizzBuzzGenerator(writer).play();

        string[] output = WriterToArray(writer);
        Assert.Equal("23", output[22]);
    }

    [Fact]
    public void TestFizzBuzzReturnsBuzzOnTheOneHundredthIteration()
    {
        TextWriter writer = new StringWriter();

        new FizzBuzzGenerator(writer).play();

        string[] output = WriterToArray(writer);
        Assert.Equal("Buzz", output[99]);
    }

    [Fact]
    public void TestFizzBuzzReturnsOneHundredLines()
    {
        TextWriter writer = new StringWriter();

        new FizzBuzzGenerator(writer).play();
        
        Assert.Equal(100, WriterToArray(writer).Length);
    }
    
    private static string[] WriterToArray(TextWriter writer)
    {
        return writer.ToString().Trim().Split('\n');
    }
}