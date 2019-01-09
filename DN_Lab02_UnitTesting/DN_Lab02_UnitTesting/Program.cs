using System;

namespace DN_Lab02_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jason's ATM");
            UserInterface();
        }
        //User Interface
        static void UserInterface()
        {
            Console.WriteLine("Select 0 to Exit\nSelect 1 for Balance\nSelect 2 for Withdrawal\nSelect 3 for Deposit\nSelect 4 for Transaction History");
            byte userInput = 0;
            try
            {
                userInput = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Format");
                UserInterface();
            }
            switch (userInput)
            {
                case 0:
                    Environment.Exit(1);
                    break;
                case 1:
                    Balance(0);
                    break;
                case 2:
                    //Withdrawal();
                    break;
                case 3:
                    //Deposit();
                    break;
                case 4:
                    //TransactionHistory();
                    break;
                default:
                    UserInterface();
                    break;
            }
        }
        //TODO: Check Balance
        static int Balance(decimal transaction)
        {
            decimal balance = 0m;
                try
                {
                    if (balance + transaction >= 0)
                    {
                        balance = balance + transaction;
                        Console.WriteLine($"Your balance is {balance}");
                        Console.WriteLine();
                        UserInterface();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Insufficient Funds for Transaction");
                    UserInterface();
                }
            
            return Convert.ToInt32(balance);
        }
        //TODO: Withdraw 
        //TODO: Deposit
        //TODO: Transaction History --Stretch
    }
}
