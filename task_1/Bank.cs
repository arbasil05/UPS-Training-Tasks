
using System;

class Program
{
    static void Main()
    {
        string userPresent = "basil";
        int userPin = 123;
        float userBalance = 5000;

        Console.WriteLine("Welcome to our bank, Please enter your credentials");

        Console.Write("Enter your username: ");
        string user = Console.ReadLine();

        Console.Write("Enter your pin: ");
        int pin = Convert.ToInt32(Console.ReadLine());

        if (user != userPresent || pin != userPin)
        {
            Console.WriteLine("Either username or pin is wrong");
            Environment.Exit(1);
        }

        Console.WriteLine($"Welcome {user}! Your account balance is ₹{userBalance}");

        while (true)
        {
            Console.WriteLine("Press 1 to deposit");
            Console.WriteLine("Press 2 to withdraw");
            Console.WriteLine("Press 3 to exit");

            Console.Write("Enter: ");
            int command = Convert.ToInt32(Console.ReadLine());

            if (command == 1)
            {
                Console.Write("Enter the amount to deposit: ");

                float amount = Convert.ToSingle(Console.ReadLine());

                if(amount <= 0)
                {
                    Console.Write("Amount should be greater than 0.");
                    continue;
                }

                userBalance += amount;

                Console.WriteLine($"Successfully deposited. Current balance: ₹{userBalance}");
            }
            else if (command == 2)
            {
                Console.Write("Enter the amount to withdraw: ");
                float amount = Convert.ToSingle(Console.ReadLine());

                if (amount <= userBalance)
                {
                    userBalance -= amount;
                    Console.WriteLine($"₹{amount} successfully withdrawn");
                    Console.WriteLine($"Current balance: ₹{userBalance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else if (command == 3)
            {
                Console.WriteLine("Thank you for using our bank!");
                break;
            }
        }
    }
}
