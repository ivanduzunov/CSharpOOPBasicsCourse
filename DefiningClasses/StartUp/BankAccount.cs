using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BankAccount
{
    private int id;
    private double balance;

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public double Balance
    {
        get { return this.balance; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance can not be negative");
            }
            this.balance = value;
        }
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }
    public void Withdrow(double amount)
    {
        this.balance -= amount;
    }
    public override string ToString()
    {
        return $"Account {this.id}, ballance {this.balance}";
    }
}
