using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    /*  Test Behaviors:
     *  
     *  1.  The method throws an ArgumentOutOfRangeException if the debit amount is greater than the balance.
     *  2.  The method throws an ArgumentOutOfRangeException if the debit amount is less than zero.
     *  3.  If the debit amount is valid, the method subtracts the debit amount from the account balance.
     */
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
