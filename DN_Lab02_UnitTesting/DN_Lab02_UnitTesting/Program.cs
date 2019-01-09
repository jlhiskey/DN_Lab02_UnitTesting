using System;

namespace DN_Lab02_UnitTesting
{
    public class Program
    {
        public static decimal balance = 0.00M;

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
                    Console.WriteLine();
                    Balance(0);
                    break;
                case 2:
                    Withdrawal();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    //TransactionHistory();
                    break;
                default:
                    UserInterface();
                    break;
            }
        }
        //Check Balance
        public static decimal Balance(decimal transaction)
        {
                    if (balance + transaction >= 0)
                    {
                        balance = balance + transaction;
                        Console.WriteLine($"Your balance is ${balance}");
                        Console.WriteLine();
                        UserInterface();
                    }
                else {
                    Console.WriteLine("Insufficient Funds for Transaction");
                    UserInterface();
                }
            
            return balance;
        }
        //Withdrawal
        public static decimal Withdrawal()
        {
            decimal withdrawal = 0;
            Console.WriteLine("Please enter how much you would like to withdraw.");
            
            try
            {
                withdrawal = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Balance(-withdrawal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use numerical values. Ex 10.00");
                Withdrawal();
            }

            return -withdrawal;
        }
        //Deposit
        public static decimal Deposit()
        {
            decimal deposit = 0;
            Console.WriteLine("Please enter how much you would like to deposit.");

            try
            {
                deposit = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
                Balance(deposit);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use numerical values. Ex 10.00");
                Deposit();
            }

            return deposit;
        }
        //TODO: Transaction History --Stretch
    }
}
