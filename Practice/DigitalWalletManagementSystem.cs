using System;
using System.Collections.Generic;

// custom exception
public class UserAlreadyExistsException : Exception
{
    public UserAlreadyExistsException(string message) : base(message)
    {

    }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {

    }
}

// model
public class Wallet
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
    public List<string> TransactionHistory { get; set; }

    // constructor
    public Wallet(int userId, string name, double balance)
    {
        UserId = userId;
        Name = name;
        Balance = balance;
        TransactionHistory = new List<string>();
    }

    // method
    public void AddTransaction(string message)
    {
        TransactionHistory.Add(message);
    }
}

// utility class
public class Utility
{
    public Dictionary<int, Wallet> Dict = new Dictionary<int, Wallet>();
    public void CreateWallet(int userId, string name, double balance)
    {
        if (Dict.ContainsKey(userId))
        {
            throw new UserAlreadyExistsException("User already exist");
        }
        if (balance < 0)
        {
            throw new Exception("Invalid initial balance");
        }

        Wallet wallet = new Wallet(userId, name, balance);
        wallet.AddTransaction("Wallet Credited with Rupees : " + balance);
        Dict.Add(userId, wallet);
        Console.WriteLine("wallet added successfully");
    }

    public void Deposit(int userId, double amount)
    {
        if (!Dict.ContainsKey(userId))
        {
            throw new Exception("User not found");
        }
        if (amount <= 0)
        {
            throw new Exception("Invalid deposit amount");
        }

        Dict[userId].Balance += amount;
        Dict[userId].AddTransaction("Deposited Rupees : " + amount);
    }

    public void Withdraw(int userId, double amount)
    {
        if (!Dict.ContainsKey(userId))
        {
            throw new Exception("User not found");
        }
        if (amount <= 0)
        {
            throw new Exception("Invalid withdrawal amount");
        }
        if (amount > Dict[userId].Balance)
        {
            throw new InsufficientFundsException("Insufficient amount");
        }
        Dict[userId].Balance -= amount;
        Dict[userId].AddTransaction("Withdraw Rupees : " + amount);
    }

    public void Transfer(int fromUserId, int toUserId, double amount)
    {
        if (!Dict.ContainsKey(fromUserId) || !Dict.ContainsKey(toUserId))
        {
            throw new Exception("User not found");
        }
        if (amount <= 0)
        {
            throw new Exception("Invalid transfer amount");
        }
        if (Dict[fromUserId].Balance < amount)
        {
            throw new InsufficientFundsException("Invalid Transfer amount");
        }

        Dict[fromUserId].Balance -= amount;
        Dict[fromUserId].AddTransaction("Amount deducted Rupees : " + amount);

        Dict[toUserId].Balance += amount;
        Dict[toUserId].AddTransaction("Amount credited Rupees : " + amount);
    }

    public int GetHighestBalanceUser()
    {
        if (Dict.Count == 0)
            throw new Exception("No user found");

        double highestBalanceUser = -1;
        int highestBalanceUserId = -1;

        foreach (var kv in Dict)
        {
            if (kv.Value.Balance > highestBalanceUser)
            {
                highestBalanceUser = kv.Value.Balance;
                highestBalanceUserId = kv.Key;
            }
        }

        return highestBalanceUserId;
    }

    public List<string> GetTransactionHistory(int userId)
    {
        if (!Dict.ContainsKey(userId))
        {
            throw new Exception("User not found");
        }

        return Dict[userId].TransactionHistory;
    }
}

public class Program
{
    static void Main()
    {
        Utility utility = new Utility();

        while (true)
        {
            Console.WriteLine("1. Create Wallet");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Show Highest Balance User");
            Console.WriteLine("6. Show Transaction History");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter choice");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter UserId");
                        int userId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Balance");
                        double balance = double.Parse(Console.ReadLine());

                        utility.CreateWallet(userId, name, balance);
                        break;

                    case 2:
                        Console.WriteLine("Enter userId");
                        userId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount");
                        double amount = double.Parse(Console.ReadLine());

                        utility.Deposit(userId, amount);
                        break;

                    case 3:
                        Console.WriteLine("Enter userId");
                        userId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount");
                        amount = double.Parse(Console.ReadLine());

                        utility.Withdraw(userId, amount);
                        break;

                    case 4:
                        Console.WriteLine("Enter fromUserId");
                        int fromUserId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter toUserId");
                        int toUserId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount");
                        amount = double.Parse(Console.ReadLine());

                        utility.Transfer(fromUserId, toUserId, amount);
                        break;

                    case 5:
                        int ans = utility.GetHighestBalanceUser();
                        Console.WriteLine($"Highest Balance userId : {ans}");
                        break;

                    case 6:
                        Console.WriteLine("Enter userId");
                        userId = int.Parse(Console.ReadLine());

                        List<string> list = utility.GetTransactionHistory(userId);
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 7:
                        Console.WriteLine("Thank you");
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch (UserAlreadyExistsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}





/*
PRACTICAL EXAM QUESTION
Secure Digital Wallet Management System (Advanced)
Problem Statement

Develop a C# program to manage a secure digital wallet system.

The system should maintain user wallet details using:

Dictionary<int, Wallet>

Where:

Key → UserId (int)

Value → Wallet object

Class Requirements
1️⃣ Wallet Class

Create a class Wallet with the following properties:

UserId (int)

Name (string)

Balance (double)

TransactionHistory (List<string>)

The constructor must initialize:

All properties

TransactionHistory list

Create a method:

AddTransaction(string message)

that adds a message to TransactionHistory.

2️⃣ Custom Exception Classes

Create the following custom exceptions:

UserAlreadyExistsException

InsufficientFundsException

Both must inherit from Exception.

Utility Class Requirements

Create a class Utility that contains:

Dictionary<int, Wallet> wallets

Implement the following methods:

1️⃣ CreateWallet(int userId, string name, double balance)

If the user already exists → throw UserAlreadyExistsException

If initial balance is negative → throw Exception("Invalid initial balance")

Else create Wallet object and store in dictionary

2️⃣ Deposit(int userId, double amount)

If user does not exist → throw Exception("User not found")

If amount <= 0 → throw Exception("Invalid deposit amount")

Add amount to balance

Record transaction:

Deposited ₹amount
3️⃣ Withdraw(int userId, double amount)

If user does not exist → throw Exception("User not found")

If amount <= 0 → throw Exception("Invalid withdrawal amount")

If amount > balance → throw InsufficientFundsException

Deduct amount

Record transaction:

Withdrawn ₹amount
4️⃣ Transfer(int fromUserId, int toUserId, double amount)

If either user does not exist → throw Exception("User not found")

If amount <= 0 → throw Exception("Invalid transfer amount")

If sender balance is insufficient → throw InsufficientFundsException

Deduct from sender

Add to receiver

Record transaction in both wallets

5️⃣ GetHighestBalanceUser()

Return the UserId of the user with the highest balance

If no users exist → throw Exception("No users found")

6️⃣ GetTransactionHistory(int userId)

Return List<string>

If user not found → throw Exception("User not found")

Main Method Requirements

Create a menu-driven program:

1. Create Wallet
2. Deposit
3. Withdraw
4. Transfer
5. Show Highest Balance User
6. Show Transaction History
7. Exit

Use:

try-catch for FormatException

try-catch for custom exceptions

try-catch for general Exception

Program must not crash.

Additional Conditions

Everything must be written in one file

No LINQ

No multiple Utility classes

Follow proper OOP structure

This is a high-level practical exam question. dont answer only read the ques
*/
