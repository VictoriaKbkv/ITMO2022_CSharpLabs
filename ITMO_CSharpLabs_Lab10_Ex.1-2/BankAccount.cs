using System;
using System.IO;
using System.Collections;
class BankAccount : IDisposable
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;
    private Queue tranQueue = new Queue();
    private bool disposed = false;

    internal BankAccount() 
    {
        accNo = NextAccNo();
        accBal = 0;
        accType = AccountType.Checking;
    }

    internal BankAccount(AccountType assignType)
    {
        accNo = NextAccNo();
        accBal = 0;
        accType = assignType;
    }

    internal BankAccount(decimal assignBalance)
    {
        accNo = NextAccNo();
        accBal = assignBalance;
        accType = AccountType.Checking;
    }

    internal BankAccount(AccountType assignType, decimal assignBalance)
    {
        accNo = NextAccNo();
        accBal = assignBalance;
        accType = assignType;
    }

    public static long NextAccNo()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
        accBal = accBal + amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal = accBal - amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
        {
            this.Deposit(amount);
        }
    }

    public void Dispose()
    {
        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            swFile.WriteLine("Transactions:");
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    public Queue Transactions()
    {
        return tranQueue;
    }

    public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
    public string Type()
    {
        return accType.ToString();
    }

    ~BankAccount()
    {
        Dispose();
    }
}