using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocash
{

    class Account
    {
        private string name;
        private double balance,sndBalance, payBalance,billBalance, amount;
        public int pin, pinmatch;

        public Account()
        {
            Console.Write("Enter user name: ");
            name = Console.ReadLine();

            Console.Write("Enter balance: ");
            balance = double.Parse(Console.ReadLine());

            Console.Write("Enter pin: ");
            pin = int.Parse(Console.ReadLine());
        }

        public void Menu()
        {
            int choice;

            do
            {
                Console.WriteLine("Enter your choice\n1.Check balance\n2.Send Money\n3.Make Payment\n4.Pay Bill\n5.Exit");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is {balance}");
                        break;

                    case 2:
                        Console.Write("Enter amount:");
                        amount = double.Parse(Console.ReadLine());

                        sndBalance = balance - amount;
                        balance = sndBalance;
                        Console.Write($"You have succesfully sent money your current balance is {sndBalance}");

                        break;
                    case 3:
                        Console.Write("Make payments:");
                        amount = double.Parse(Console.ReadLine());

                        payBalance = balance - amount;
                        balance = payBalance;
                        Console.Write($"You have succesfully sent money your current balance is {payBalance}");

                        break;
                    case 4:
                        Console.Write("Pay bill :");
                        amount = double.Parse(Console.ReadLine());

                        billBalance = balance - amount;
                        balance = billBalance;
                        Console.Write($"You have succesfully sent money your current balance is {billBalance}");

                        break;

                    case 5:
                    default:
                        Console.WriteLine("Thank you for using our ecocash services");
                        break;

                }

            }
            while (choice!=5);

        }

        
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Account acc = new Account();
            Console.WriteLine("Enter your ecocash pin:");
            acc.pinmatch = int.Parse(Console.ReadLine());
            if (acc.pinmatch == acc.pin)
            {
                acc.Menu();
            }
            else
            {
                Console.WriteLine("Password does not match with our records, please reenter password!");
            }
            Console.ReadLine();
        }
      

    }
}
