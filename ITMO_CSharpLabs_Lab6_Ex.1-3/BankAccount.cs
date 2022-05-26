class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;

    public static long NextAccNo()
    {
        return nextAccNo++;
    }
    public void Populate(decimal balance)
    {
        accNo = NextAccNo();
        accBal = balance;
        accType = AccountType.Checking;
    }
    public decimal Deposit(decimal amount)
    {
        accBal = accBal + amount;
        return accBal;
    }
    
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal = accBal - amount;
        }
        return sufficientFunds;
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
