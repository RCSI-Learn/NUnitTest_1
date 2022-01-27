using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest {
    internal class BankAccountTest {
        private NUnitTestExample.BankAccount bankAccount;
        [SetUp]
        public void SetUp() {
            //Arrange
            bankAccount = new NUnitTestExample.BankAccount(1000);
        }

        [Test]
        public void AddingFundsUpdatesBalance() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act
            bankAccount.Add(500);

            //Assert
            Assert.AreEqual(1500, bankAccount.Balance);
        }

        [Test]
        public void AddingNegativeFundsThrows() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act

            //Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => bankAccount.Add(-500));
        }

        [Test]
        public void WithDrawingFundsUpdatesBalance() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act
            bankAccount.WithDraw(500);

            //Assert
            Assert.AreEqual(500, bankAccount.Balance);
        }

        [Test]
        public void WithDrawingNegativeFundsThrows() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.WithDraw(-500));
        }

        [Test]
        public void WithDrawingMoreThanBalanceThrows() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.WithDraw(2000));
        }

        [Test]
        public void TransferingFundsUpdatesBalanceBothAccounts() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);
            NUnitTestExample.BankAccount otherBankAccount = new NUnitTestExample.BankAccount();

            //Act
            bankAccount.TransferFundsTo(otherBankAccount, 500);

            //Assert
            Assert.AreEqual(500, bankAccount.Balance);
            Assert.AreEqual(500, otherBankAccount.Balance);
        }

        [Test]
        public void TransferToNonExistingAccountsThrows() {
            ////Arrange
            //NUnitTestExample.BankAccount bankAccount = new NUnitTestExample.BankAccount(1000);

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => bankAccount.TransferFundsTo(null, 2000));
        }
    }
}
