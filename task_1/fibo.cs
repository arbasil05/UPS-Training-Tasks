using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your limit : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.Write(a);
        Console.Write(" ");
        Console.Write(b);
        Console.Write(" ");
        while(n > 0)
        {
            int sum = a + b;
            Console.Write(sum);
            Console.Write(" ");
            a = b;
            b = sum;
            n--;
        }
    }
}