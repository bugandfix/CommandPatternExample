
using CommandPatternExample.Interfaces;
using CommandPatternExample.Services;

namespace CommandPatternExample.Commands;

public class WithdrawCommand : ICommand
{
    private readonly AccountService _accountService;
    private readonly decimal _amount;

    public WithdrawCommand(AccountService accountService, decimal amount)
    {
        _accountService = accountService;
        _amount = amount;
    }

    public void Execute()
    {
        _accountService.Withdraw(_amount);
    }

    public void Undo()
    {
        _accountService.Deposit(_amount);
    }
}