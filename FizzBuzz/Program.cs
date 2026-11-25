// See https://aka.ms/new-console-template for more information

// This is a simple C# program that reads a string from the console and prints it back to the console.
using FizzBuzz;

Console.WriteLine("Enter a string/text: ");

// Read the input string from the console until an empty line is entered
string input = "";
string? line = Console.ReadLine();

// Keep reading lines until the user enters an empty line 
while (!string.IsNullOrEmpty(line))
{
    if (input.Length > 0)                        // Add a newline character before appending the next line if input is not empty
    {
        input += "\n";                             // Append a newline character to the input string 
    }
    input += line;                                    // Append the line to the input string
    line = Console.ReadLine();                            // Read the next line from the console
}

FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();          // Create an instance of the FizzBuzzDetector class
Results results = fizzBuzzDetector.getOverlappings(input);          // Call the getOverlappings method to process the input string

Console.WriteLine("Output: " + results.Output);             // Print the output string to the console

Console.WriteLine($"Fizz Count: {results.FizzCount}");                      // Print the fizz count to the console