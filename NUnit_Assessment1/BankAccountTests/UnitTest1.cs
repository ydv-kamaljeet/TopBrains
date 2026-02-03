using NUnit.Framework;
using BankAccountApp;
using System;

namespace BankAccountTests
{
    [TestFixture]   //  Required test attribute for class
    public class UnitTest
    {
        [Test]   //  Required test attribute
        public void Test_Deposit_ValidAmount()
        {
            Program account = new Program(1000m);

            account.Deposit(500m);

            Assert.That(account.Balance, Is.EqualTo(1500m));
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            Program account = new Program(1000m);

            Exception ex = Assert.Throws<Exception>(() => account.Deposit(-200m));

            Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            Program account = new Program(1000m);

            account.Withdraw(400m);

            Assert.That(account.Balance, Is.EqualTo(600m));
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            Program account = new Program(500m);

            Exception ex = Assert.Throws<Exception>(() => account.Withdraw(800m));

            Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
        }
    }
}
