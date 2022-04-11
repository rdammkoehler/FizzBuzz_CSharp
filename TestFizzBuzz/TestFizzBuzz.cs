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
    
    // Rule 4: Multiples of 3 & 5 return 'FizzBuzz'
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
}