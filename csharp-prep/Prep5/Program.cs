using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string userName = InputUserName();
        int userNumber = InputUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        Display(userName, squaredNumber);
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string InputUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int InputUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Display(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}