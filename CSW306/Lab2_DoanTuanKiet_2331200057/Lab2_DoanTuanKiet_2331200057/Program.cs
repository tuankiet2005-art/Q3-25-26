using Lab2_DoanTuanKiet_2331200057;
using Microsoft.VisualBasic;
using System;
using System.Drawing;

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

            book1.PrintDetails();
            Console.WriteLine();

            //Excercise 2
            Member mem1 = new Member("001", "Mr Tuna", "tuna@gmail.com");
            Member mem2 = new Member("002", "Mr Tick", "tick@gmail.com");
            Member mem3 = new PremiumMember("003", "Mr Brick", "brick@gmail.com", DateTime.Now, 10);

            mem3.PrintDetails();
            Console.WriteLine();

            //Exercise 3
            Transaction borrow = new BorrowTransaction("001", DateTime.Now, mem1, book1);
            borrow.Execute();
            book1.PrintDetails();
            Transaction returnBook = new ReturnTransaction("002", DateTime.Now, mem1, book1);
            returnBook.Execute();
            book1.PrintDetails();
            Console.WriteLine();

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
                book1.PrintDetails();
            }
            Console.WriteLine();

            //Exercise 5
            mem1.ExcuteBorrow();
            mem3.ExcuteBorrow();
            Console.WriteLine();

            //Exercise 6
            Library library = new Library();
            library.Books.Add(book1);
            library.Members.Add(mem1);
            library.DisplayLibraryInfo();
            Console.WriteLine();

            //Exercise 7
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification("This is notification");
            notificationService.SendNotification("Server is maintaining", "Kiet");
            notificationService.SendNotification("Server down", new List<String> { "Kha", "Tuan", "Lam"});

            AdvancedNotificationService advancedNotificationService = new AdvancedNotificationService();
            advancedNotificationService.SendNotification("Advanced notification");
            Console.WriteLine();

            //Exercise 8
            LibraryCard myCard = new LibraryCard("LIB-999", mem1);
            myCard.RenewCard();
            myCard.DisplayLibraryCardInfo();
            Console.WriteLine();

            //Exercise 9
            BookClass class1 = new BookClass("123", "C# Guide", "Kiet");
            BookClass class2 = new BookClass("123", "C# Guide", "Kiet");
            Console.WriteLine(class2 == class1);

            BookRecord record1 = new BookRecord("123", "C# Guide", "Kiet");
            BookRecord record2 = new BookRecord("123", "C# Guide", "Kiet");
            Console.WriteLine(record2 == record1);

            BookRecord record3 = record1 with { Title = "C# Guide 2.0" };
            Console.WriteLine(record3.Title);
            Console.WriteLine();

            //Explanation:
            //Class: When using ==, it compares by reference. Since class1 and class2 are located in two different memory locations, the result is False even though the contents are identical.
            //Record: C# automatically overrides the comparison method to check the value of the attributes. If all attributes are the same, the result is True.

            //Exercise 10
            Library library1 = new Library();
            NotificationService notificationService1 = new NotificationService();
            library1.OnBookBorrowed += notificationService1.SMSNotification;
            library1.OnBookBorrowed += notificationService1.EmailSendNotification;

            library1.BorrowBook(book1, mem1);

        }

    }
}