using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class PremiumMember : Member, IMemberActions
    {

        public DateTime membershipExpiry { get; set; }
        public int maxBooksAllowed { get; set; }
        public PremiumMember(string memberID, string name, string email, DateTime membershipExpiry, int maxBooksAllowed) : base(memberID, name, email)
        {
            this.membershipExpiry = membershipExpiry;
            this.maxBooksAllowed = maxBooksAllowed;
        }

        public void ExcuteBorrow()
        {
            Console.WriteLine(base.name + " is borrowing a book.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Membership Expiry: " + membershipExpiry);
            Console.WriteLine("Max Books Allowed: " + maxBooksAllowed);
        }
    }
}
