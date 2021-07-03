using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    abstract class Unit
    {
        public int id;
        public double baggage;
        public Unit(int id,double baggage)
        {
            this.id = id;
            this.baggage = baggage;
        }

        public abstract void Display();
        public abstract void Add(Unit unit);
        public abstract void Remove(Unit unit);
    }

    class  Passenger : Unit
    {
        

        public Passenger(int id,double baggage) : base(id,baggage){}

        public override void Display()
        {
            Console.WriteLine(Convert.ToString(id) + ' ' + Convert.ToString(baggage));
        }

        public override void Add(Unit unit)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Unit unit)
        {
            throw new NotImplementedException();
        }
    }

    class BusinessClassPassenger : Passenger
    {
        public BusinessClassPassenger(int id, double baggage) : base(id, baggage) { }
        public double baggage
        {
            get { return baggage; }
            set {
                if (value <= 35) baggage = value;
                else Console.WriteLine("Maximum luggage weight for business class 35 kg");
            }
        }

        public override void Display()
        {
            Console.WriteLine("Business class passenger: " + base.id + "\nBaggage: " + base.baggage);
        }
    }

    class FirstClassPassenger : Passenger
    {
        public FirstClassPassenger(int id, double baggage) : base(id, baggage) { }
        public double baggage
        {
            get { return baggage; }
            set{ baggage = value; }
        }
        public override void Display()
        {
            Console.WriteLine("First class passenger: " + base.id + "\nBaggage: " + base.baggage);
        }
    }

    class EconomyClassPassenger : Passenger
    {
        public EconomyClassPassenger(int id, double baggage) : base(id, baggage) { }
        public double baggage
        {
            get { return baggage; }
            set
            {
                if (value <= 20) baggage = value;
                else Console.WriteLine("Maximum luggage weight for economy class 20 kg");
            }
        }

        public override void Display()
        {
            Console.WriteLine("Economy class passenger: " + base.id + "\nBaggage: " + base.baggage);
        }
    }

    class Pilot : Unit
    {
        public Pilot(int id) : base(id,0) { }

        public override void Display()
        {
            Console.WriteLine("Pilot: " + id);
        }
        public override void Add(Unit unit)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Unit unit)
        {
            throw new NotImplementedException();
        }
    }

    class Stewardess : Unit
    {
        public Stewardess(int id) : base(id,0) { }

        public override void Display()
        {
            Console.WriteLine("Pilot: " + id);
        }
        public override void Add(Unit unit)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Unit unit)
        {
            throw new NotImplementedException();
        }
    }




}
