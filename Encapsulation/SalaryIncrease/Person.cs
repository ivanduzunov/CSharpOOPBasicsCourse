using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName => this.firstName;

    public int Age => this.age;

    public double Salary => this.salary;



    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            this.salary += this.salary * bonus / 200;
        }

        else
        {
            this.salary += this.salary * bonus / 100;
        }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
    }
}

