using System;

public class RetailSalesPerson : Salesman
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void sell()
    {
        Console.WriteLine(string.Format("hi my name is {0}, buy this pen!", this.FullName));
    }
}