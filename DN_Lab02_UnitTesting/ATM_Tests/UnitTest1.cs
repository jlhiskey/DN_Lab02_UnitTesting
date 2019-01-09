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
            Assert.Equal(100, Program.Balance(100));
        }
        //Test Withdraw
        [Fact]
        public void TestingWithdraw()
        {
            Assert.Equal(100, Program.Withdrawal(100.00));
        }
        //Test Deposit
        [Fact]
        public void TestingDeposit()
        {

        }
        //Maybe Test Transaction History
    }
}
