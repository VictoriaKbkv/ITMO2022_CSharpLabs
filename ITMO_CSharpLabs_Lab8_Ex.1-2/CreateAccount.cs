using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(AccountType.Deposit);
        BankAccount acc3 = new BankAccount(100);
        BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);
        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
        acc1.Deposit(700);
        acc2.Deposit(1000);
        acc3.TransferFrom(acc4, 100);
        acc4.Withdraw(100);
        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);

    }


    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}", toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransaction tran in toWrite.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();

    }

}