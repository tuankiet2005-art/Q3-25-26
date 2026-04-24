using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class BorrowTransaction : Transaction
    {
        Book bookBorrowed;
        public BorrowTransaction(string transactionID, DateTime transactionDate, Member member, Book bookBorrowed) : base(transactionID, transactionDate, member)
        {
            this.bookBorrowed = bookBorrowed;
        }

        public override void Execute()
        {
            bookBorrowed.CopiesAvailable--;
        }
    }
}
