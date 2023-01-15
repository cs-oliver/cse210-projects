using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the numbers list, adds any number that is not 0
        List<int> numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string response = Console.ReadLine();
            input = int.Parse(response);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }



        // Calculating the sum of the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the list is: {sum}");



        // Calculating the average of the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        // Finding the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}