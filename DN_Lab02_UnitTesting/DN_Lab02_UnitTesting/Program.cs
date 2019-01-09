using System;
using System.Collections.Generic;

namespace DN_Lab02_UnitTesting
{
    public class Transaction : IEquatable<Transaction>
    {
        public string TransactionType { get; set; }

        public decimal TransactionValue { get; set; }

        public decimal BalanceValue { get; set; }

        public override string ToString()
        {
            return "Amount: $" + TransactionValue + "   Transaction Type: " + TransactionType + "    Current Balance: $" + BalanceValue;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Transaction objAsTransaction = obj as Transaction;
            if (objAsTransaction == null) return false;
            else return Equals(objAsTransaction);
        }

        public bool Equals(Transaction other)
        {
            if (other == null) return false;
            return (this.TransactionValue.Equals(other.TransactionValue));
        }

    }
    public class Program
    {
        public static decimal balance = 0.00M;
        public static List<Transaction> transactions = new List<Transaction>();

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
                    UserInterface();
                    break;
                case 2:
                    Console.WriteLine("Please enter how much you would like to withdraw.");
                    decimal withdrawValue = decimal.Parse(Console.ReadLine());
                    Withdrawal(withdrawValue);
                    UserInterface();
                    break;
                case 3:
                    Console.WriteLine("Please enter how much you would like to deposit.");
                    decimal depositValue = decimal.Parse(Console.ReadLine());
                    Deposit(depositValue);
                    UserInterface();
                    break;
                case 4:
                    TransactionHistory();
                    UserInterface();
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
                if (transaction > 0)
                {
                 
                    transactions.Add(new Transaction() { TransactionType = "Deposit", TransactionValue = transaction, BalanceValue = balance });
                }
                if (transaction < 0)
                {
                    transactions.Add(new Transaction() { TransactionType = "Withdrawal", TransactionValue = transaction, BalanceValue = balance });
                }


            }
                else {
                    Console.WriteLine("Insufficient Funds for Transaction");
                    
                }
            
            return balance;
        }
        //Withdrawal
        public static decimal Withdrawal(decimal value)
        {
            decimal withdrawal = value;
            
            
            try
            {
                Console.WriteLine();
                Balance(-withdrawal);
                return -withdrawal;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use numerical values. Ex 10.00");
               
            }
            return 0;
            
        }
        //Deposit
        public static decimal Deposit(decimal value)
        {
            decimal deposit = value;

            try
            {
                Console.WriteLine();
                Balance(deposit);
                return deposit;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use numerical values. Ex 10.00");
                
            }
            return 0;
            
        }
        public static void  Clear()
        {
             balance = 0;          
        }
        //Transaction History --Stretch
        public static int TransactionHistory()
        {
            Console.WriteLine();
            foreach (Transaction aTransaction in transactions)
            {
                Console.WriteLine(aTransaction);     
            }
            Console.WriteLine();
            return 0;
        }
    }
}
