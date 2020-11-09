using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Book
    {
        private String bookName;

        public String BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private String bookAuthor;

        public String BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private String bookId;

        public String BookID
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private String bookType;

        public String BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            Console.WriteLine("Empty Book constructor called ");
       }
        public Book(String bookName,String bookAuthor,String bookId,String bookType,int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void BookInfo()
        {
            Console.WriteLine("Book Nmae: " + bookName);
            Console.WriteLine("Author Name: "+bookAuthor);
            Console.WriteLine("Book Id: "+bookId);
            Console.WriteLine("Book Type: "+bookType);
            Console.WriteLine("Book Copy: "+bookCopy);
            Console.ReadLine();
        }
        public void AddBookCopy(int x)
        {
             x = bookCopy;
             x += x;
            Console.WriteLine("Book Copy: " +x);

        }
    }
}
