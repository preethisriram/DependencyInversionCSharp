using System;

namespace DependencyInjectionPractice
{
    public interface IAccount
    {
        void PrintData();
    }

    //Implemented the IAccount interface in SavingAccount class  
    public class SavingAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Saving account data.");
        }
    }

    //Implemented the IAccount interface in CurrentAccount class  
    public class CurrentAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Current account data.");
        }
    }

    //Account class is not depended on any other classes.  
    //So now it is loosely coupled.  
    public class Account
    {
        private IAccount account;

        //Passing IAccount interface as parameter to Account constructor  
        public Account(IAccount account)
        {
            this.account = account;
        }

        public void PrintAccounts()
        {
            account.PrintData();
        }
    }

    class Program
    {
        static void Main()
        {
            //If you want to calls the SavingAccount class PrintAccounts() method,   
            //just created the object of SavingAccount() and   
            //pass as parameter to Account constructor.  
            IAccount savingAccount = new SavingAccount();
            Account account = new Account(savingAccount);
            account.PrintAccounts();

            //If you want to calls the CurrentAccount class PrintAccounts() method,   
            //just created the object of CurrentAccount () and   
            //pass as parameter to Account constructor.  
            IAccount currentAccount = new CurrentAccount();
            account = new Account(currentAccount);
            account.PrintAccounts();
            Console.ReadLine();
        }
    }
}
