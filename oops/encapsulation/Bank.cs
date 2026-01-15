using System;

class BankAccount {
    private int bankBalance;

    public void Deposit(int amount) {
        bankBalance += amount;
    }

    public int CheckBalance() {
        return bankBalance;
    }
}

class Bank {
    static void Main(String[] args) {
        BankAccount bank = new BankAccount();
        bank.Deposit(2000);

        Console.WriteLine("Bank balance: " + bank.CheckBalance());
    }
}
