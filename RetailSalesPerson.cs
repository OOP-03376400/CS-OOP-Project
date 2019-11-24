using System;

public class RetailSalesPerson : Salesman, ISelfDeveloping
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void sell()
    {
        Console.WriteLine(string.Format("hi my name is {0}, buy this pen!", this.FullName));
    }
    public void Develop(){
        Console.WriteLine("I develop myself by seening videos");
    }
}