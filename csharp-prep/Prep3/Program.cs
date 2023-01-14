using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write("What is your guess?");
        string guessinput = Console.ReadLine();
        int guess = int.Parse(guessinput);

        string response = "";

        if (guess == number)
        {
            response = "Correct!";
        }
        else if (guess < number)
        {
            response = "Higher";
        }
        else if (guess > number)
        {
            response = "Lower";
        }

        Console.WriteLine($"{response}");
    }
}