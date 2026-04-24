using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class Book : IPrintable
    {
        private string ISBN { get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else throw new ArgumentException("Year must be positive number");
            }
        }
        private int copiesAvailable;

        public int CopiesAvailable
        {
            get { return copiesAvailable; }

            set
            {
                if (value >= 0)
                {
                    copiesAvailable = value;
                }
                else throw new ArgumentException("Copy Available must be non-negative number");
            }
        }

        public Book(string isbn, string title, string author)
        {
            this.ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Copies Available: " + copiesAvailable);
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }

    }
}
