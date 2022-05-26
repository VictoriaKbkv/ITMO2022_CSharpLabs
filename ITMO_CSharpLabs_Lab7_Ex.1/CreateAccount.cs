using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount berts = new BankAccount();
        BankAccount freds = new BankAccount();
        const decimal initialAmount = 100;
        const decimal toTransfer = 200;
        berts.Populate(initialAmount);
        freds.Populate(initialAmount);
        Console.WriteLine("Before transfer");
        Write(berts);
        Write(freds);
        berts.TransferFrom(freds, toTransfer);
        Console.WriteLine();
        Console.WriteLine("After transfer");
        Write(berts);
        Write(freds);

    }


    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}", toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }

}