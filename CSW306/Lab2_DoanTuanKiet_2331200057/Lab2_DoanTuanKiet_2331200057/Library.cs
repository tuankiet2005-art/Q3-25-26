using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class Library
    {
        string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library()
        {
            this.LibraryName = "Default Name";
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public Library(string LibraryName, List<Book> initialBooks)
        {
            this.LibraryName = LibraryName;
            Books = initialBooks;
            Members = new List<Member>();
        }

        public Library(Library copyLibrary)
        {
            this.LibraryName = copyLibrary.LibraryName;
            this.Books = new List<Book>(copyLibrary.Books);
            this.Members = new List<Member>(copyLibrary.Members);
        }

        public void DisplayLibraryInfo()
        {
            Console.WriteLine("Library name: " + LibraryName);
            Console.WriteLine("Number of books: " + Books.Count);
            Console.WriteLine("Number of members: " + Members.Count);
        }

        //Exercise 10
        public event Action<Book, Member> OnBookBorrowed;

        public void BorrowBook(Book book, Member member)
        {
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                member.ExcuteBorrow();
                OnBookBorrowed?.Invoke(book, member);
            }
            else
            {
                Console.WriteLine("Unavailable.");
            }

        }
    }
}
