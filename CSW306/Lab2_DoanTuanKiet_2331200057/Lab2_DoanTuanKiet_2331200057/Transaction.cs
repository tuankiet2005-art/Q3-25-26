using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    abstract class Transaction
    {
        string transactionID { get; set; }
        DateTime transactionDate { get; set; }
        Member member;

        public Transaction(string transactionID, DateTime transactionDate, Member member)
        {
            this.transactionID = transactionID;
            this.transactionDate = transactionDate;
            this.member = member;
        }

        public abstract void Execute();

    }
}
