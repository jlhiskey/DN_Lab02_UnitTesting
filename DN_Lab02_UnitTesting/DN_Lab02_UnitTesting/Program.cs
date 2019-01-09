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
        //TODO: User Interface
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
                    Balance();
                    break;
                case 2:
                    Withdrawal();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    TransactionHistory();
                    break;
                default:
            }
        }
        //TODO: Check Balance
        //TODO: Withdraw 
        //TODO: Deposit
        //TODO: Transaction History --Stretch
    }
}
