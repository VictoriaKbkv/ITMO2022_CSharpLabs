using System;

class CreateAccount
{
    static void Main()
    {
        Console.WriteLine("Sid's Account");
        long sidsAccNo = Bank.CreateAccount();
        BankAccount sids = Bank.GetAccount(sidsAccNo);
        TestDeposit(sids);
        TestWithdraw(sids);
        Write(sids);
        if (Bank.CloseAccount(sidsAccNo))
        {
            Console.WriteLine("Account closed");
        }
        else
        {
            Console.WriteLine("Something went wrong closing the account");
        }
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

    static void TestDeposit(BankAccount acc)
    {
        Console.Write("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        acc.Deposit(amount);

    }

    static void TestWithdraw(BankAccount acc)
    {
        Console.Write("Enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!acc.Withdraw(amount))
        {
            Console.WriteLine("Insufficient funds.");
        }

    }
}