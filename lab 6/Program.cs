using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Program
    {
         static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Nayan", "17-35043-2", "SE", 3.35f);
            s2.ShowInfo();


            Account a1 = new Account();
            Account a2 = new Account("Sheik Nayan","123-456-789",50000);
            a2.BankAccInfo();

            Book b1 = new Book();
            Book b2 = new Book("Himu","Humayun Ahmed","rf-123","Novel",02);
            b2.BookInfo();
            
            
        }
    }
}
