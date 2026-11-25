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
            ValidateInput(input);

            StringBuilder output = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();
            int fizzCount = 0;
            int wordCount = 0;

            void AppendCurrentWord()
            {
                if (currentWord.Length == 0)
                {
                    return;
                }

                wordCount++;
                output.Append(GetReplace(currentWord.ToString(), wordCount));

                if (wordCount % 3 == 0 || wordCount % 5 == 0)
                {
                    fizzCount++;
                }

                currentWord.Clear();
            }

            foreach (char character in input)
            {
                if (IsAlphanumeric(character))
                {
                    currentWord.Append(character);
                }
                else
                {
                    AppendCurrentWord();
                    output.Append(character);
                }
            }

            AppendCurrentWord();

            return new Results(output.ToString(), fizzCount);
        }
    }
}
