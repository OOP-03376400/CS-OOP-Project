using System;

namespace CS_OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            RetailSalesPerson ericTheSalesdude = new RetailSalesPerson("Erik", "Erikson");
            Console.WriteLine(ericTheSalesdude.FullName);
            ericTheSalesdude.sell();
            ericTheSalesdude.Develop();

            WebDeveloper mike = new WebDeveloper("angular6");
            mike.Code();
            mike.Develop();
        }
    }
}
