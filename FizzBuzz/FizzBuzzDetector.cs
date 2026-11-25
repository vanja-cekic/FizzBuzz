using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // ------ This class is responsible for detecting FizzBuzz patterns in a given input string ------ //
    public class FizzBuzzDetector
    {
        // ** This method processes the input string to detect FizzBuzz patterns and returns the results ** //
        public Results getOverlappings(string input)
        {
            string output = "";
            int fizzCount = 0;

            return new Results(output, fizzCount);                  // Return the results as an instance of the Results class
        }

        // ** This method validates the input string to ensure it meets the required criteria ** //
        private void ValidateInput(string input)
        {
            if (input == null)
            {
                 throw new ArgumentNullException(nameof(input), "Input cannot be null.");          // Throw an exception if the input is null
            }

            if (input.Length <= 7 || input.Length >= 100)
            {
                throw new ArgumentException("Input length must be greater than 7 and less than 100 characters.", nameof(input));          // Throw an exception if the input length is not within the specified range
            }
        }
    }
}
