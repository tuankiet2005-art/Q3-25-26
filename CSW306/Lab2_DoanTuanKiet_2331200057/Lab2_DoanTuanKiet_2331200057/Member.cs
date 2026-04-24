using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class Member : IPrintable
    {
        string memberID { get; set; }
        string name { get; set; }
        string email { get; set; }

        public Member(string memberID, string name, string email)
        {
            this.memberID = memberID;
            this.name = name;
            this.email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Member ID: " + memberID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }
    }
}
