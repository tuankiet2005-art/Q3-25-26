using Lab2_DoanTuanKiet_2331200057;
using System;

namespace DoanTuanKiet
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Excercise 1
            Book book1 = new Book("123", "The Golf", "Justin Gate");

            book1.Year = 2020;
            book1.CopiesAvailable = 5;

            book1.DisplayInfo();

            //Excercise 2
            Member mem1 = new Member("001", "Mr Tuna", "tuna@gmail.com");
            Member mem2 = new Member("002", "Mr Tick", "tick@gmail.com");
            Member mem3 = new PremiumMember("003", "Mr Brick", "brick@gmail.com", DateTime.Now, 10);

            mem3.DisplayInfo();

            //Exercise 3
            Transaction borrow = new BorrowTransaction("001", DateTime.Now, mem1, book1);
            borrow.Execute();
            Console.WriteLine(book1.CopiesAvailable);
            Transaction returnBook = new ReturnTransaction("002", DateTime.Now, mem1, book1);
            returnBook.Execute();
            Console.WriteLine(book1.CopiesAvailable);

            //Exercise 4
            List<Transaction> transactionList = new List<Transaction>();
            transactionList.Add(new BorrowTransaction("003", DateTime.Now, mem2, book1));
            transactionList.Add(new BorrowTransaction("004", DateTime.Now, mem3, book1));
            transactionList.Add(new ReturnTransaction("005", DateTime.Now, mem2, book1));
            transactionList.Add(new ReturnTransaction("006", DateTime.Now, mem3, book1));

            foreach (Transaction tran in transactionList)
            {
                tran.Execute();
                Console.WriteLine("Book info after transaction: ");
                book1.DisplayInfo();
            }

                
                                                                                         
        }

    }
}