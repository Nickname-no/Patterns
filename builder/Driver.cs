using System;
using System.Collections.Generic;

namespace Builder
{
    public enum Categories
    {
        D,
        B,
        S
    }
    
    public abstract class Driver
    {
        protected static int countDrivers;
        public int id;
        public Categories category;
        public void info()
        {
        }
    }

    class TaxiDriver : Driver
    {
        
        public TaxiDriver()
        {
            this.category = Categories.B;
            if (Driver.countDrivers == null)
            {
                Driver.countDrivers = 1;
                this.id = Driver.countDrivers;
            }
            else
            {
                Driver.countDrivers += 1;
                this.id = Driver.countDrivers;
            }
            
        }

        public void info()
        {
            Console.WriteLine(id + " " + category);
        }
    }
    
    class BusDriver : Driver
    {
        public int id;
        public Categories category ;
        public BusDriver()
        {
            this.category = Categories.D;
            if (Driver.countDrivers == null)
            {
                Driver.countDrivers = 1;
                this.id = Driver.countDrivers;
            }
            else
            {
                Driver.countDrivers += 1;
                this.id = Driver.countDrivers;
            }
        }

        public void info()
        {
            Console.WriteLine(id + " " + category);
        }
    }

    class ShipDriver : Driver
    {
        public int id;
        public Categories category;
        public ShipDriver()
        {
            this.category = Categories.S;
            if (Driver.countDrivers == null)
            {
                Driver.countDrivers = 1;
                this.id = Driver.countDrivers;
            }
            else
            {
                Driver.countDrivers += 1;
                this.id = Driver.countDrivers;
            }
        }

        public void info()
        {
            Console.WriteLine(id + " " + category);
        }
    }
}