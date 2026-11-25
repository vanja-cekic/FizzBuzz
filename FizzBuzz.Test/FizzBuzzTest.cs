using Xunit;

namespace FizzBuzz.Test
{
    // ------* This class contains unit tests for the FizzBuzzDetector class *------ //
    public class FizzBuzzTest
    {
        // ** This test method checks if the third word in the input string is replaced with "Fizz" ** //
        [Fact]
       public void FirstWORdsremainsUnchangde()
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();                                 // Create an instance of the FizzBuzzDetector class
            string input = "Detector";                                   // Input string to be tested

            Results result = fizzBuzzDetector.getOverlappings(input);                               // Call the getOverlappings method with the input string and store the result

            Assert.Equal("Detector", result.Output);                  // Assert that the output string is as expected

            Assert.Equal(0, result.FizzCount);                                                      // Assert that the FizzCount is as expected
        }

        // ** This test method checks that the second word remains unchanged ** //
        [Fact]
        public void SecondWordRemainsUnchanged()
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();                                 // Create an instance of the FizzBuzzDetector class
            string input = "Detector works";                                   // Input string to be tested
           
            Results result = fizzBuzzDetector.getOverlappings(input);                               // Call the getOverlappings method with the input string and store the result
           
            Assert.Equal("Detector works", result.Output);                  // Assert that the output string is as expected
            Assert.Equal(0, result.FizzCount);                                                      // Assert that no Fizz replacement is made
        }

        // ** This test method checks if the third word in the input string is replaced with "Fizz" ** //
        [Fact]
        public void ReplaceThirdWordWithFizz()
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();                                 // Create an instance of the FizzBuzzDetector class
            string input = "Detector is helping!";                                   // Input string to be tested
            
            Results result = fizzBuzzDetector.getOverlappings(input);                               // Call the getOverlappings method with the input string and store the result
           
            Assert.Equal("Detector is Fizz!", result.Output);                  // Assert that the output string is as expected
            Assert.Equal(1, result.FizzCount);                                                      // Assert that the FizzBuzzCount is as expected
        }

        // ** This test method checks if the getOverlappings method throws an ArgumentNullException when the input string is null ** //
        [Fact]
        public void RejectNullInput()
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();                                 // Create an instance of the FizzBuzzDetector class
            string input = null;                                   // Input string to be tested
           
            Assert.Throws<ArgumentNullException>(() => fizzBuzzDetector.getOverlappings(input));                               // Call the getOverlappings method with the input string and assert that it throws an ArgumentNullException
        }

        // ** This test method checks if the getOverlappings method throws an ArgumentException when the input string is too short ** //
        [Fact]
        public void RejectShortInput()
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();                                 // Create an instance of the FizzBuzzDetector class
            string input = "short";                                   //Input string to be tested
           
            Assert.Throws<ArgumentException>(() => fizzBuzzDetector.getOverlappings(input));                               // Call the getOverlappings method with the input string and assert that it throws an ArgumentException
        }
    }
}
