using System;

namespace Builder
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            TaxiBuilder taxiBuilder = new TaxiBuilder();
            Boarding boarding = manager.Manage(taxiBuilder);
            boarding.AddPassenger(new Child());
            boarding.AddPassenger(new Child());
            boarding.childSits.info();
            boarding.AddPassenger(new Beneficiary());
            boarding.AddPassenger(new Beneficiary());
            boarding.AddPassenger(new Beneficiary());
            boarding.info();
            Console.Read();
        }
    }
}