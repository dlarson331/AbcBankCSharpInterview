﻿using System;

namespace abc_bank
{
    public class Transaction
    {
        public readonly double amount;

        private DateTime transactionDate;

        public Transaction(double amount) 
        {
            this.amount = amount;

            this.transactionDate = DateProvider.getInstance().Now();
        }
    }
}