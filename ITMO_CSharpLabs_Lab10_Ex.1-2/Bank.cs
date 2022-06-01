using System.Collections;

    class Bank
    {
        private Bank() { }
        private static Hashtable accounts = new Hashtable();
        
        public static long CreateAccount()
        {
            BankAccount NewAccount = new BankAccount();
            long NewAccNuber = NewAccount.Number();
            accounts[NewAccNuber] = NewAccount;
            return NewAccNuber;
        }

        public static long CreateAccount(AccountType assignType, decimal assignBalance)
        {
            BankAccount NewAccount = new BankAccount(assignType, assignBalance);
            long NewAccNuber = NewAccount.Number();
            accounts[NewAccNuber] = NewAccount;
            return NewAccNuber;
        }

        public static long CreateAccount(AccountType assignType)
        {
            BankAccount NewAccount = new BankAccount(assignType);
            long NewAccNuber = NewAccount.Number();
            accounts[NewAccNuber] = NewAccount;
            return NewAccNuber;
        }

        public static long CreateAccount(decimal assignBalance)
        {
            BankAccount NewAccount = new BankAccount(assignBalance);
            long NewAccNuber = NewAccount.Number();
            accounts[NewAccNuber] = NewAccount;
            return NewAccNuber;
        }
    public static bool CloseAccount(long AccountNumber)
        {
            BankAccount closing = new BankAccount();
            closing = (BankAccount)accounts[AccountNumber];
            if (closing != null)
            { 
                accounts.Remove(AccountNumber);
                closing.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static BankAccount GetAccount(long AccountNumber)
        {
        return (BankAccount)accounts[AccountNumber];
        }
    }

