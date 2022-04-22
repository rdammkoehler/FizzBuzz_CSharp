# FizzBuzz

This is a demo repo for the class FizzBuzz problem.
The intent is to provide an example of using TDD with C#.

This will be a primitive experience.

## FizzBuzz Problem Statement

Write a program that prints the numbers from 1 to 100

and for multiples of '3' print "Fizz" instead of the number

and for the multiples of '5' print "Buzz"

and for the multiples of both '3' and '5' print "FizzBuzz".

## What Tooling?

Using;

* Rider 2021.3.4

* xUnit 2.4.2.0

## Steps for starting from scratch

1) Install tooling if you must/need to
   1) [Rider](https://www.jetbrains.com/rider/download/)
   
   2) [xUnit](https://xunit.net/docs/getting-started/netfx/jetbrains-rider)
   
2) Our First Real Test

   1) TDD - If you are not familiar with TDD, here is a quick explanation
    
      1) The TDD Microcycle has three stages.
       
         1) Red - The tests don't pass. This might be because the code won't compile, or because the test's assertion fails. In any case, remember 'Don't Refactor on Red'. At this point you should be looking to do whatever is needed to make your code compile, run, and pass the test.
          
         2) Green - The tests pass. Once your tests are running green you can make design adjustments, clean things up, refactor as much as you like. The tests you have will ensure you don't break anything. A piece of advice, only make small changes, one at a time, and run the test between changes. If you make a mistake it's a short trip back to green, just undo the last thing you did.
          
         3) Refactor - Clean up the code. Refactoring is the process of improving the design of the code to ensure that it is clean and understandable. It might be simply making variable and method names more accurate, or it might be removing duplication. In any case, refactoring steps should be as small as possible and you should run the tests after each step to ensure you haven't broken a test.
          
   2) Looking at our problem statement, the first test might be, given an input of '1' expect to receive back '1'
    
   ```csharp   
   [Fact]
   public void fizzBuzzReturnsOneGivenOne()
   {
      var inputValue = 1;
   
      var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
   
      Assert.Equal("1", result);
   }
   ```

   3) This won't even run because FizzBuzzGenerator does not exist. So create a file called `FizzBuzz.cs` in the FizzBuzz project to satisfy the compiler

   ```csharp
   namespace FizzBuzz
   {
      public class FizzBuzzGenerator
      {
          public static string fizzBuzzFor(int inputValue)
          {
              return "";
          }
      }
   }
   ```
         
   4) Run the test, the result should be RED. 
      
   >  You can run the tests by right clicking on your solution and picking 'Run Unit Tests' 

    ```shell
    Xunit.Sdk.EqualException
    Assert.Equal() Failure
             ↓ (pos 0)
    Expected: 1
    Actual:   
             ↑ (pos 0)
      at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsOneGivenOne() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 15
    ```
    What this means is that the method we created, `fizzBuzzFor` returned an empty string and we expected "1"

   5) Add just enough code to `FizzBuzz.cs` to run the tests. This appears naive, but we are trying to add just enough code to pass the test and no more.
    
```csharp
namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static string fizzBuzzFor(int inputValue)
        {
            return "1";
        }
    }
}
```

   6) Run the tests again and see that they pass. 

   7) For our second test we want to move on to the next simplest thing we can think of. It seems reasonable that we would test the number 2. So, given 2 as an input we expect "2" as the output.
      1) Add another test into the `UnitTest1.cs` file that looks like this;

        ```csharp
        [Fact]
        public void fizzBuzzReturnsTwoGivenTwo()
        {
           var inputValue = 2;
           
           var result = FizzBuzzGenerator.fizzBuzzFor(inputValue);
           
           Assert.Equal("2", result);
        }
        ```
      
      2) Run the tests again and see that the new tests fails, "1" is not "2".

        ```shell
        Xunit.Sdk.EqualException
        Assert.Equal() Failure
                  ↓ (pos 0)
        Expected: 2
        Actual:   1
                  ↑ (pos 0)
           at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsTwoGivenTwo() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 25
        ```

      3) Again, add just enough code to make this pass. In this case, it seems likely that just converting the input to a string will satisfy both tests. Your implementation should look like this;

        ```csharp
        namespace FizzBuzz
        {
            public class FizzBuzzGenerator
            {
                public static string fizzBuzzFor(int inputValue)
                {
                    return inputValue.ToString();
                }
            }
        }
        ```

      4) Run the tests and see that they pass.
      
   8) Now that we are running green it is a good time to commit the code into source control. We've completed 'Rule 1', which is implied by the other rules. Numbers that are not divisible by 3 or 5 should be returned as strings.

      1) Use the source control tools to create a commit of the code
      
   9) This is also a good opportunity to look at our code for chances to refactor. Since our implementation is one line long, there isn't anything to do. But our tests are somewhat repetitive, we could shorten those up by collapsing the tests into a single line each. Of course this is optional but, if you like, modify the test code to look like this;

       ```csharp
       using FizzBuzz;
       using Xunit;
        
       namespace TestFizzBuzz
       {
           public class FizzBuzzGeneratorTests
           {
               [Fact]
               public void fizzBuzzReturnsOneGivenOne()
               {
                   Assert.Equal("1", FizzBuzzGenerator.fizzBuzzFor(1));
               }
                
               [Fact]
               public void fizzBuzzReturnsTwoGivenTwo()
               {
                   Assert.Equal("2", FizzBuzzGenerator.fizzBuzzFor(2));
               }
           }
       }
       ```
   10) We've completed Rule 1 (number is returned as a string). We could add additional tests but they wouldn't prove that we'd completed Rule 1 any more than the two test we have. So lets move on to Rule 2; numbers divisible by 3 should return `Fizz`.
       1) Add a test using the number 3 as input that expects output of `Fizz`
    ```csharp
    [Fact]
    public void fizzBuzzReturnsFizzGivenThree()
    {
        Assert.Equal("Fizz", FizzBuzzGenerator.fizzBuzzFor(3));
    }
    ```
       2) Run the test and see it fail
    ```shell
    Xunit.Sdk.EqualException
    Assert.Equal() Failure
              ↓ (pos 0)
    Expected: Fizz
    Actual:   3
              ↑ (pos 0)
       at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsFizzGivenThree() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 23
    ```
       3) Modify the implementation (`FizzBuzz.cs`) with the simplest thing that can make the test pass. An `IF` statement is probably appropriate.
    ```csharp
    public static string fizzBuzzFor(int inputValue)
    {
        if (inputValue == 3)
        {
            return "Fizz";
        }
        return inputValue.ToString();
    }
    ```
       4) Run your test and see them all pass
   11) Having only handled the input value of 3 in the previous test case, we aren't done with Rule 2. The next likely test therefore is the input value of 6.
       1) Add a test using the number 6 as input that expects output of `Fizz`
    ```csharp
    [Fact]
            public void fizzBuzzReturnsFizzGivenSix()
            {
                Assert.Equal("Fizz", FizzBuzzGenerator.fizzBuzzFor(6));
            }
    ```
       2) Run the test and see it fail
    ```shell
    Xunit.Sdk.EqualException
    Assert.Equal() Failure
              ↓ (pos 0)
    Expected: Fizz
    Actual:   6
              ↑ (pos 0)
       at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsFizzGivenSix() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 29
    ```
       3) Modify the implementation with the simplest thing that can work. If you are familiar with the modulo operator (`%`) in C# and you are comfortable with a little math, any number mod 3 that is equal to zero, is divisible by 3; therefore our solution could be this;
    ```csharp
    public static string fizzBuzzFor(int inputValue)
    {
        if (inputValue % 3 == 0)
        {
            return "Fizz";
        }
        return inputValue.ToString();
    }
    ```
       4) Run your tests and see them all pass
   12) At this point we've completed two of the rules for FizzBuzz. Note that we grouped our tests around our rules. Rule 1; return the number as a string. Rule 2; if the number is divisible by 3, return `Fizz`. So we can move on to Rule 3; if the number is divisible by 5, return `Buzz`.
       1) Add a test using the number 5 as input and expecting output of `Buzz`
    ```csharp
    [Fact]
    public void fizzBuzzReturnsBuzzGivenFive()
    {
        Assert.Equal("Buzz", FizzBuzzGenerator.fizzBuzzFor(5));
    }
    ```
       2) Run the test and see it fail
    ```shell
    Xunit.Sdk.EqualException
    Assert.Equal() Failure
              ↓ (pos 0)
    Expected: Buzz
    Actual:   5
              ↑ (pos 0)
       at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsBuzzGivenFive() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 35
    ```
       3) Modify the implementation with the simplest thing that can work. Again, we can just use an `IF` here.
    ```csharp
    public static string fizzBuzzFor(int inputValue)
    {
        if (inputValue == 5)
        {
            return "Buzz";
        }
        if (inputValue % 3 == 0)
        {
            return "Fizz";
        }
        return inputValue.ToString();
    }
    ```
       4) Run your tests and see them all pass
   13) OK, just like before, we are half way through the rule. What test could we add that covers all things divisible by 5? How about 10?
       1) Add a test using the number 10 as input and expecting output of `Buzz`
    ```csharp
    [Fact]
    public void fizzBuzzReturnsBuzzGivenTen()
    {
        Assert.Equal("Buzz", FizzBuzzGenerator.fizzBuzzFor(10));
    }
    ```
       2) Run the test and see it fail
    ```shell
    Xunit.Sdk.EqualException
    Assert.Equal() Failure
              ↓ (pos 0)
    Expected: Buzz
    Actual:   10
              ↑ (pos 0)
       at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsBuzzGivenTen() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 41
    ```
       3) Modify the implementation with the simplest thing that can work. Lets use the same technique with modulus that we used with divisible by 3.
    ```csharp
    public static string fizzBuzzFor(int inputValue)
    {
        if (inputValue % 5 == 0)
        {
            return "Buzz";
        }
        if (inputValue % 3 == 0)
        {
            return "Fizz";
        }
        return inputValue.ToString();
    }
    ```
       4) Run your tests and see them all pass
       
   14) Great. Three rules down. Now we can repeat this process for things divisible by both 3 and 5. The first case of that being 15

       1) Add a test using the number 15 as input and expecting output of `FizzBuzz`
       
        ```csharp
        [Fact]
        public void fizzBuzzReturnsFizzBuzzGivenFifteen()
        {
            Assert.Equal("FizzBuzz", FizzBuzzGenerator.fizzBuzzFor(15));
        }
        ```
       
       2) Run the test and see it fail
       
        ```shell
        Xunit.Sdk.EqualException
        Assert.Equal() Failure
                  ↓ (pos 0)
        Expected: FizzBuzz
        Actual:   Buzz
                  ↑ (pos 0)
           at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsFizzBuzzGivenFifteen() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 47
        ```
    
        > Notice this failure is slightly different; we got 1/2 of the answer because of our `Buzz` rule

       3) Modify the implementation with the simplest thing that can work.

        ```csharp
        public static string fizzBuzzFor(int inputValue)
        {
            if (inputValue == 15)
            {
                return "FizzBuzz";
            }
        
            if (inputValue % 5 == 0)
            {
                return "Buzz";
            }
        
            if (inputValue % 3 == 0)
            {
                return "Fizz";
            }
        
            return inputValue.ToString();
        }
        ```

       4) Run your tests and see them all pass

   15) And the second half of our rule will make this work for all things divisible by 3 and 5
       1) Add a test using the number 30 as input and expecting output of `FizzBuzz`
       
        ```csharp
        [Fact]
        public void fizzBuzzReturnsFizzBuzzGivenThirty()
        {
            Assert.Equal("FizzBuzz", FizzBuzzGenerator.fizzBuzzFor(30));
        }
        ```
       
       2) Run the test adn see it fail
       
        ```shell
        Xunit.Sdk.EqualException
        Assert.Equal() Failure
                  ↓ (pos 0)
        Expected: FizzBuzz
        Actual:   Buzz
                  ↑ (pos 0)
           at TestFizzBuzz.FizzBuzzGeneratorTests.fizzBuzzReturnsFizzBuzzGivenThirty() in /Users/rpd/RiderProjects/FizzBuzz/TestFizzBuzz/UnitTest1.cs:line 53
        ```
       
       3) Modify the implementation with the simplest thing that can work.
       
        ```csharp
        public static string fizzBuzzFor(int inputValue)
        {
            if (inputValue % 5 == 0 && inputValue % 3 == 0)
            {
                return "FizzBuzz";
            }
        
            if (inputValue % 5 == 0)
            {
                return "Buzz";
            }
        
            if (inputValue % 3 == 0)
            {
                return "Fizz";
            }
        
            return inputValue.ToString();
        }
        ```

       4) Run your tests and see them all pass.

   16) Great. We have a working solution for all the rules. Before we move onto the 1-100 part of the implementation, is there an opportunity to clean up the code?

        1) We could have only one return point in the implementation.
       
        ```csharp
        public static string fizzBuzzFor(int inputValue)
        {
            string response;
            if (inputValue % 5 == 0 && inputValue % 3 == 0)
            {
                response = "FizzBuzz";
            }
            else if (inputValue % 5 == 0)
            {
                response = "Buzz";
            }
            else if (inputValue % 3 == 0)
            {
                response = "Fizz";
            }
            else
            {
                response = inputValue.ToString();
            }
        
            return response;
        }
        ```
       
       2) Run the tests, are we still green?

       3) OK, that's a little bit cleaner, but can we make it even better? I don't like that if-else chain very much.
        
        ```csharp
        public static string fizzBuzzFor(int inputValue)
        {
            string response = "";
            if (inputValue % 3 == 0)
            {
                response += "Fizz";
            }
        
            if (inputValue % 5 == 0)
            {
                response += "Buzz";
            }
        
            if (response.Length == 0)
            {
                response = inputValue.ToString();
            }
        
            return response;
        }
        ```
        5) Run the tests, are we still green?
       
        6) Now we could use a turnary 
       
        ```csharp
        public static string fizzBuzzFor(int inputValue)
        {
            string response = "";
            if (inputValue % 3 == 0)
            {
                response += "Fizz";
            }
        
            if (inputValue % 5 == 0)
            {
                response += "Buzz";
            }
        
            return string.IsNullOrEmpty(response) ? inputValue.ToString() : response;
        }
        ```
       
        7) Run the tests, are we still green?
