using System.Collections;

class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;
    private Queue tranQueue = new Queue();

    public BankAccount()
    {
        accNo = NextAccNo();
        accBal = 0;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType assignType)
    {
        accNo = NextAccNo();
        accBal = 0;
        accType = assignType;
    }

    public BankAccount(decimal assignBalance)
    {
        accNo = NextAccNo();
        accBal = assignBalance;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType assignType, decimal assignBalance)
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
}
