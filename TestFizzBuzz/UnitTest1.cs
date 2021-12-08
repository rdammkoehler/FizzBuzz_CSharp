using System;
using FizzBuzz;
using Xunit;

namespace TestFizzBuzz
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void fizzBuzzReturnsOneGivenOne()
        {
            var inputValue = 1;
            
            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("1", result);
        }

        [Fact]
        public void fizzBuzzReturnsTwoGivenTwo()
        {
            var inputValue = 2;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("2", result);
        }

        [Fact]
        public void fizzBuzzReturnsFizzGivenThree()
        {
            var inputValue = 3;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void fizzBuzzReturnsFizzGivenSix()
        {
            var inputValue = 6;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void fizzBuzzReturnsBuzzGivenFive()
        {
            var inputValue = 5;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void fizzBuzzReturnsBuzzGivenTen()
        {
            var inputValue = 10;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void fizzBuzzReturnsFizzBuzzGivenFifteen()
        {
            var inputValue = 15;

            var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
            
            Assert.Equal("FizzBuzz", result);
        }
    }
}