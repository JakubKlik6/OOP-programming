using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_account jakubAccount = new Bank_account("Jakub", "123456789");

            jakubAccount.GiveMoney(500);
            jakubAccount.GetMoney(600);
            jakubAccount.AccountBalance();

            Console.WriteLine(jakubAccount);

            Console.WriteLine("----------");
            Console.WriteLine("");
        }

    }
}   
