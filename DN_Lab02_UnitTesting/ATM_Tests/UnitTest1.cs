using System;
using Xunit;
using DN_Lab02_UnitTesting;

namespace ATM_Tests
{
    public class UnitTest1
    {
        //Test Balance
        [Fact]
        public void TestingBalance()
        {
            Program.Clear();
            Program.Deposit(100);
            Assert.Equal(100, Program.Balance(0));
        }
        //Test Overdrawn Balance
        [Fact]
        public void TestingOverDrawnBalance()
        {
            Program.Clear();
            Assert.Equal(0, Program.Balance(-100));
        }
        //Test Withdraw
        [Fact]
        public void TestingWithdraw()
        {
            Program.Clear();
            Assert.Equal(-100, Program.Withdrawal(100));
        }
        //Test Deposit
        [Fact]
        public void TestingDeposit()
        {
            Program.Clear();
            Assert.Equal(100, Program.Deposit(100));
        }
        //Maybe Test Transaction History
    }
}
