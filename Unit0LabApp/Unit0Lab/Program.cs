/*
 * Unit0Lab
 * Author: Noah
 * When: Jan 2025
 */

using Unit0Lab;
using System.Runtime.InteropServices.Marshalling;
using Unit0Lab;

int low, high;
int difference; // difference between low and  high

// get positive low number 
// get high number that is greater than low

low = Utilities.GetPositiveInt("low number");
high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue);

// calculate and print difference between low and high
difference = high - low;
Console.WriteLine($"\ndifference between {low} and {high} is {difference}");

// create an array and store number between low and high
int[] numbers = new int[difference + 1];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = low + i;
}

Console.WriteLine("Numbers in the array:");
foreach (int num in numbers)
    Console.WriteLine(num);

// create a text file and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // Close file writing
Console.WriteLine("\nFile written");

// read the numbers back from the file and print out the sum of the numbers
StreamReader streamReader = File.OpenText("numbers.txt");
string nextLine;
for (int i = 0; i < numbers.Length; i++)
{
    nextLine = streamReader.ReadLine() ?? "";
    numbers[i] = Convert.ToInt32(nextLine);
}
streamReader.Close();

Console.WriteLine("Values from file");
foreach (int num in numbers)
    Console.WriteLine(num);

int sum = numbers.Sum(); // Calculate Sum of Values in Nums Array
Console.WriteLine($"\nSum: {sum}");