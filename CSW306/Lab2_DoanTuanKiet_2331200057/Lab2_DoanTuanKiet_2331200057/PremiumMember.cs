using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class PremiumMember : Member
    {

        public DateTime membershipExpiry { get; set; }
        public int maxBooksAllowed { get; set; }
        public PremiumMember(string memberID, string name, string email, DateTime membershipExpiry, int maxBooksAllowed) : base(memberID, name, email)
        {
            this.membershipExpiry = membershipExpiry;
            this.maxBooksAllowed = maxBooksAllowed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Membership Expiry: " + membershipExpiry);
            Console.WriteLine("Max Books Allowed: " + maxBooksAllowed);
        }
    }
}
