using System;

class Program{

    static void Main()
    {
        Console.Write("Enter your number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int sum = 0;

        while(temp > 0)
        {
            int remainder = temp%10;
            sum = sum*10 + remainder;
            temp = temp/10;
        }

        if(sum == number)
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }
   

}