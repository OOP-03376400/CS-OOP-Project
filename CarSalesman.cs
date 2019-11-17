using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void sell()
    {
        Console.WriteLine(string.Format("hi my name is {0}, buy this car!", this.FullName));
    }
}