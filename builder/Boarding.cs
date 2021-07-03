using System;
using System.Collections.Generic;

namespace Builder
{
    public  class Boarding
    {
        public Driver driver { get; set; }

        public List<IPassenger> passengers { get; set; }

        public ICar car { get; set; }

        public ChildSit childSits { get; set; }

        public void info()
        {
            if((driver == null) || (passengers == null))
            {
                Console.WriteLine("No ready");
            }
            else
            {
                Console.WriteLine("Ready");
            }
        }

        public void AddPassenger(IPassenger passenger)
        {
            if(driver.category == Categories.B)
            {
                if (this.passengers.Count <= 3)
                {
                    if (passenger.GetType() == typeof(Beneficiary))
                    {
                        Console.WriteLine("There are no proferential places for taxis");
                        this.passengers.Add(new Adult());
                    }
                    else if(passenger.GetType() == typeof(Child))
                    {
                        this.childSits.countChildSit += 1;
                    }
                    else
                    {
                        this.passengers.Add(passenger);
                    }
                }
                else
                {
                    Console.WriteLine("No free space");
                }
            }
            else
            {
                if (this.passengers.Count <= 39)
                {
                    this.passengers.Add(passenger);

                }
                else
                {
                    Console.WriteLine("No free space");
                }
            }
        }
        
    }
}