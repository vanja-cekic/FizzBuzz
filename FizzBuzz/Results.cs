using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // ------ This class represents the results of a FizzBuzz operation ------ //
    // ------ It contains the output string and the count of "Fizz" occurrences ------ //
    public class Results
    {
        public string Output { get; set; }            // Property to hold the output string of the FizzBuzz operation
        public int FizzCount { get; set; }                                    // Property to hold the count of "Fizz" occurrences in the output

        // ** Constructor to initialize the FizzBuzzResults object with output and fizz count ** //
        public Results(string output, int fizzCount)
        {
            Output = output;                                        // Initialize the Output property with the provided output string
            FizzCount = fizzCount;                               // Initialize the FizzCount property with the provided count of "Fizz" occurrences
        }
    }
}
