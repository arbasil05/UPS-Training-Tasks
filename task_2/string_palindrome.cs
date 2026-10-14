using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your string : ");
        string word = Console.ReadLine();

        int i = 0;
        int j = word.Length - 1;

        bool flag = false;

        while(i < j)
        {
            if(word[i] != word[j])
            {
                flag = true;
                break;
            }

            i++;
            j--;
        }

        if (flag)
        {
            Console.WriteLine($"{word} is not a palindrome");
        }
        else
        {
            Console.WriteLine($"{word} is a palindrome");
        }
    }
}