using System;

abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

class Manager : Employee
{
    public Manager(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 145000 + 10000;
    }
}

class Clerk : Employee
{
    public Clerk(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 30000 + 3000;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("Krisma");
        Clerk clerk = new Clerk("Shrisha");

        Console.WriteLine("Manager Name: " + manager.Name);
        Console.WriteLine("Manager Salary: " + manager.CalculateSalary());

        Console.WriteLine();

        Console.WriteLine("Clerk Name: " + clerk.Name);
        Console.WriteLine("Clerk Salary: " + clerk.CalculateSalary());
    }
}