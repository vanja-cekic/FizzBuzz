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
        // ** This method validates the input string to ensure it meets the required criteria ** //
        private void ValidateInput(string input)
        {
            // Check if the input is null and throw an exception if it is
            if (input == null)
            {
                 throw new ArgumentNullException(nameof(input), "Input cannot be null.");          // Throw an exception if the input is null
            }

            // Check if the input length is less than or equal to 7 or greater than or equal to 100 and throw an exception if it is
            if (input.Length <= 7 || input.Length >= 100)                                               
            {
                throw new ArgumentException("Input length must be greater than 7 and less than 100 characters.", nameof(input));          // Throw an exception if the input length is not within the specified range
            }
        }

        // ** This method checks if a character is alphanumeric (a letter or a digit) ** //
        private bool IsAlphanumeric(char charater)
        {
            if ((charater >= 'a' && charater <= 'z') || (charater >= 'A' && charater <= 'Z') || (charater >= '0' && charater <= '9'))                   // Check if the character is a letter (lowercase or uppercase) or a digit
            {
                return true;                        // Return true if the character is alphanumeric
            }
            return false;               // Return false if the character is not alphanumeric
        }

        // ** This method determines the appropriate replacement string based on the word count ** //
        private string GetReplace(string word, int wordCount)
        { 
            if (wordCount % 15 == 0)            // Check if the word count is divisible by both 3 and 5 (i.e., divisible by 15)
            {
                return "FizzBuzz";
            }
            else if (wordCount % 3 == 0)                        // Check if the word count is divisible by 3
            {
                return "Fizz";
            }
            else if (wordCount % 5 == 0)                            // Check if the word count is divisible by 5
            {
                return "Buzz";
            }
            else
            {
                return word;
            }
        }

        // ** This method processes the input string to detect FizzBuzz patterns and returns the results ** //
        public Results getOverlappings(string input)
        {
            ValidateInput(input);          // Validate the input string

            string output = "";
            string currentWord = "";
            int fizzCount = 0;
            int wordCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsAlphanumeric(input[i]))
                {
                    currentWord += input[i];          // Build the current word by appending alphanumeric characters
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        wordCount++;                                 // Increment the word count when a non-alphanumeric character is encountered and the current word is not empty

                        output += GetReplace(currentWord, wordCount);                           // Append the appropriate replacement string to the output based on the current word and word count

                        if (wordCount % 3 == 0 || wordCount % 5 == 0)                        // Check if the word count is divisible by 3
                        {
                            fizzCount++;                                    // Increment the Fizz count if the word count is divisible by 3
                        }
                        currentWord = "";                // Reset the current word for the next iteration
                    }
                    output += input[i];                                             // Append the non-alphanumeric character to the output
                }

                if (currentWord.Length > 0)
                {
                    wordCount++;                                            // Increment the word count for the last word if it exists
                     output += GetReplace(currentWord, wordCount);                                   // Append the appropriate replacement string to the output based on the last word and word count
                    
                    if (wordCount % 3 == 0 || wordCount % 5 == 0)                        // Check if the word count is divisible by 3
                    {
                        fizzCount++;                                    // Increment the Fizz count if the word count is divisible by 3
                    }
                }
                
            }
            return new Results(output, fizzCount);                  // Return the results as an instance of the Results class
        }
    }
}
