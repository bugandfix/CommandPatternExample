using CommandPatternExample.Commands;
using CommandPatternExample.Services;
using CommandPatternExample;
using CommandPatternExample.Invoker;




var accountService = new AccountService();

var depositCommand = new DepositCommand(accountService, 100);
var withdrawCommand = new WithdrawCommand(accountService, 50);

var invoker = new CommandInvoker();
invoker.ExecuteCommand(depositCommand);
invoker.ExecuteCommand(withdrawCommand);

Console.WriteLine("Undo last command:");
invoker.Undo();

Console.WriteLine("Redo last command:");
invoker.Redo();

accountService.DisplayAccountBalance();