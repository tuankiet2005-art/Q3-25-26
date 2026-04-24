using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class ReturnTransaction : Transaction
    {
        Book bookReturned;
        public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book bookReturned) : base(transactionID, transactionDate, member)
        {
            this.bookReturned = bookReturned;
        }

        public override void Execute()
        {
            bookReturned.CopiesAvailable++;
        }
    }
}
