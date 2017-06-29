using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArg = input.Split();
            var command = cmdArg[0];

            switch (command)
            {
                case "Create":
                    Create(cmdArg, accounts);
                    break;
                case "Deposit":
                    Deposit(cmdArg, accounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArg, accounts);
                    break;
                case "Print":
                    Print(cmdArg, accounts);
                    break;
            }
        }


    }

    private static void Print(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArg[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine($"Account ID{accounts[id].ID}, balance {accounts[id].Balance:f2}");
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArg[1]);
        var ammount = double.Parse(cmdArg[2]);
        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance >= ammount)
            {
                accounts[id].Balance -= ammount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArg[1]);
        var ammount = double.Parse(cmdArg[2]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Balance += ammount;
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArg[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount account = new BankAccount();
            account.ID = id;
            accounts.Add(id, account);
        }
    }
}
