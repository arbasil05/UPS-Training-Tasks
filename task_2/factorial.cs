using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for(int i = 1; i <= number; i++)
        {
            result = result * i;
        }

        

        Console.WriteLine($"factorial of {number} is {result}");
    }
}