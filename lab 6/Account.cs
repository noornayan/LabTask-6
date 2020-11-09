using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Account
    {
        private String accName;

        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private String acid;

        public String Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            Console.WriteLine("Empty Account constructor called");
        }
        public Account(String accName,String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposite(int ammount)
        {
            balance += ammount;
        }

        public void withdraw(int ammount)
        {
            if(ammount<balance)
            {
                balance -= ammount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
            
        }

        public void BankAccInfo()
        {
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account Id: "+acid);
            Console.WriteLine("Acc Balance: " + balance+"\n\n");
        }

    }
}
