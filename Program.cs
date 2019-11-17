using System;

namespace CS_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman orenTHeSalesman = new CarSalesman("Oren", "Cohen");
            Console.WriteLine(orenTHeSalesman.FullName);
            orenTHeSalesman.sell();

            RetailSalesPerson ericTheSalesdude = new RetailSalesPerson("Erik", "Erikson");
            Console.WriteLine(ericTheSalesdude.FullName);
            ericTheSalesdude.sell();
        }
    }
}
