
using CommandPatternExample.Interfaces;
using CommandPatternExample.Services;

namespace CommandPatternExample.Commands;
public class DepositCommand : ICommand
{
    private readonly AccountService _accountService;
    private readonly decimal _amount;

    public DepositCommand(AccountService accountService, decimal amount)
    {
        _accountService = accountService;
        _amount = amount;
    }

    public void Execute()
    {
        _accountService.Deposit(_amount);
    }

    public void Undo()
    {
        _accountService.Withdraw(_amount);
    }
}


