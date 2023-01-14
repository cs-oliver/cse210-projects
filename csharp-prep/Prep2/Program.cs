using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int x = int.Parse(input);

        string grade = "";

        if (x >= 90)
        {
            grade = "A";
            if (x < 93)
            {
                grade = "A-";
            }
        }

        else if (x >= 80)
        {
            grade = "B";
            if (x >= 87)
            {
                grade = "B+";
            }
            else if (x < 83)
            {
                grade = "B-";
            }
        }

        else if (x >= 70)
        {
            grade = "C";
            if (x >= 77)
            {
                grade = "C+";
            }
            else if (x < 73)
            {
                grade = "C-";
            }
        }

        else if (x >= 60)
        {
            grade = "D";
            if (x >= 67)
            {
                grade = "D+";
            }
            else if (x < 63)
            {
                grade = "D-";
            }
        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your letter grade is: {grade}.");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class.");
        }
    }
}