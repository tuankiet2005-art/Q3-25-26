using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class LibraryCard
    {
        public string CardNumber { get; }
        public Member Owner { get; set; }
        public DateTime IssueDate { get; private set; }

        public LibraryCard(string CardNumber, Member Member)
        {
            this.CardNumber = CardNumber;
            this.Owner = Member;
            this.IssueDate = DateTime.Now;
        }

        public void RenewCard()
        {
            IssueDate = DateTime.Now;
            Console.WriteLine("Library card renewed.\nCard number {0}.\nNew issue date {1} ", CardNumber, IssueDate.ToString("dd/MM/yyyy"));
        }

        public void DisplayLibraryCardInfo()
        {
            Console.WriteLine("Library Card Number: " + CardNumber);
            Console.WriteLine("Owner: " + Owner.name);
            Console.WriteLine("Issue Date: " + IssueDate.ToString("dd/MM/yyyy"));
        }
    }
}
