using CommandPatternExample.Entities;

namespace CommandPatternExample.Services;

public class AccountService
{
    private readonly Account _account;

    public AccountService()
    {
        _account = new Account { Id = 1, Balance = 0 };
    }

    public void Deposit(decimal amount)
    {
        _account.Balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {_account.Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (_account.Balance >= amount)
        {
            _account.Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {_account.Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayAccountBalance()
    {
        Console.WriteLine($"Account Balance: {_account.Balance}");
    }
}
