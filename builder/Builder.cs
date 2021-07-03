using System;
using System.Collections.Generic;

namespace Builder
{
    public abstract class Builder
    {
        public Boarding boarding { get; set; }

        public void CreateBoarding()
        {
            this.boarding = new Boarding();
        }

        public abstract void setChildSit();
        public abstract void setDriver();
        public abstract void setPassengers();
        public abstract void setCar();

    }



    public class TaxiBuilder : Builder
    {
        public override void setDriver()
        {
            this.boarding.driver = new TaxiDriver();
        }

        public override void setPassengers()
        {
            this.boarding.passengers = new List<IPassenger>();

        }
        public override void setCar()
        {
            this.boarding.car = new Taxi();
            

        }

        public override void setChildSit()
        {
            this.boarding.childSits = new TaxiChildsit(); 
            this.boarding.childSits.countChildSit = 0;
        }

    }

    public class ShipBuilder : Builder
    {
        public override void setDriver()
        {
            this.boarding.driver = new TaxiDriver();
        }
        public override void setPassengers()
        {
            this.boarding.passengers = new List<IPassenger>();

        }
        public override void setCar()
        {
            this.boarding.car = new Taxi();
        }

        public override void setChildSit()
        {
            this.boarding.childSits = new ShipChildSit();
            this.boarding.childSits.countChildSit = 0;
        }

        

    }

    public class BusBoarding : Builder
    {
        public override void setDriver()
        {
            this.boarding.driver = new BusDriver();
        }
        public override void setPassengers()
        {
            this.boarding.passengers = new List<IPassenger>();
        }
        public override void setCar()
        {
            this.boarding.car = new Bus();

        }

        public override void setChildSit()
        {
            this.boarding.childSits = null;

        }

    }

    class Manager
    {
        public Boarding Manage(Builder builder)
        {
            builder.CreateBoarding();
            builder.setDriver();
            builder.setPassengers();
            builder.setCar();
            builder.setChildSit();
            return builder.boarding;
        }
    }
}