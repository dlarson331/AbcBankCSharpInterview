﻿using abc_bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace abc_bank_tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void Transaction()
        {
            // Arrange
            Transaction t = new Transaction(5);

            // Act
            
            // Assert
            Assert.IsTrue(t.GetType() == typeof(Transaction));
        }
    }
}
