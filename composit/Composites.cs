using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    class BusinessClassPassengerComposite : Unit
    {
        public List<Unit> businessClassPassengers;
        


        public BusinessClassPassengerComposite() : base(-1,-1)
        {
            this.businessClassPassengers = new List<Unit>();
        }

        public override void Add(Unit businessClassPassenger)
        {
            if ((businessClassPassenger.GetType() == typeof(BusinessClassPassenger)) && (this.businessClassPassengers.Count<=19) && (businessClassPassenger.baggage <= 35))
                this.businessClassPassengers.Add(businessClassPassenger);
            else Console.WriteLine("Cannot add a passanger from another class to business class");
        }

        public override void Remove(Unit unit)
        {
            businessClassPassengers.Remove(unit);
        }

        public override void Display()
        {
            foreach(var i in businessClassPassengers)
            {
                i.Display();
            }
        }
    }

    class FirstClassPassengerComposite : Unit
    {
        public List<Unit> firstClassPassengers;
        


        public FirstClassPassengerComposite() : base(-1, -1)
        {
            this.firstClassPassengers = new List<Unit>();
        }

        public override void Add(Unit firstClassPassenger)
        {
            if ((firstClassPassenger.GetType() == typeof(FirstClassPassenger)) && (firstClassPassengers.Count<=9))
                this.firstClassPassengers.Add(firstClassPassenger);
            else Console.WriteLine("Cannot add a passanger from another class to business class");
        }

        public override void Remove(Unit unit)
        {
            firstClassPassengers.Remove(unit);
        }

        public override void Display()
        {
            foreach (var i in firstClassPassengers)
            {
                i.Display();
            }
        }
    }

    class EconomClassPassengerComposite : Unit
    {
        public List<Unit> economClassPassengers;


        public EconomClassPassengerComposite() : base(-1, -1)
        {
            this.economClassPassengers = new List<Unit>();
        }

        public override void Add(Unit economClassPassenger)
        {
            if ((economClassPassenger.GetType() == typeof(EconomyClassPassenger)) && (economClassPassengers.Count <= 9) && (economClassPassenger.baggage <= 20))
                this.economClassPassengers.Add(economClassPassenger);
            else Console.WriteLine("Cannot add a passanger from another class to econom class");
        }

        public override void Remove(Unit unit)
        {
            economClassPassengers.Remove(unit);
        }

        public override void Display()
        {
            foreach (EconomyClassPassenger i in economClassPassengers)
            {
                i.Display();
            }
        }
    }


    class StewardessComposite : Unit
    {
        public List<Unit> stewardesses;


        public StewardessComposite() : base(-1, -1)
        {
            this.stewardesses = new List<Unit>();
        }

        public override void Add(Unit stewardess)
        {
            if ((stewardess.GetType() == typeof(Stewardess)) && (stewardesses.Count <= 5))
                this.stewardesses.Add(stewardess);
            else Console.WriteLine("Cannot add a passanger from another class to stewardess");
        }

        public override void Remove(Unit unit)
        {
            stewardesses.Remove(unit);
        }

        public override void Display()
        {
            foreach (var i in stewardesses)
            {
                i.Display();
            }
        }
    }

    class PilotComposite : Unit
    {
        public List<Unit> pilots;


        public PilotComposite() : base(-1, -1)
        {
            this.pilots = new List<Unit>();
        }

        public override void Add(Unit pilot)
        {
            if ((pilot.GetType() == typeof(Pilot)) && (pilots.Count <= 1))
                this.pilots.Add(pilot);
            else Console.WriteLine("Cannot add a passanger from another class to pilot");
        }

        public override void Remove(Unit unit)
        {
            pilots.Remove(unit);
        }

        public override void Display()
        {
            foreach (var i in pilots)
            {
                i.Display();
            }
        }
    }

    class Plane : Unit
    {
         public FirstClassPassengerComposite firstClassPassengerComposite { get; private set; }
         public BusinessClassPassengerComposite businessClassPassengerComposite { get; private set; }

         public EconomClassPassengerComposite economClassPassengerComposite { get; private set; }

         public PilotComposite pilotcomposit { get; private set; }

         public StewardessComposite stewardessComposite { get; private set; }

        public Plane(int id,double baggage) : base(id, baggage)
        {
            this.firstClassPassengerComposite = new FirstClassPassengerComposite();
            this.businessClassPassengerComposite = new BusinessClassPassengerComposite();
            this.economClassPassengerComposite = new EconomClassPassengerComposite();
            this.pilotcomposit = new PilotComposite();
            this.stewardessComposite = new StewardessComposite();
        }

        public override void Display()
        {
            firstClassPassengerComposite.Display();
            businessClassPassengerComposite.Display();
            economClassPassengerComposite.Display();
            pilotcomposit.Display();
            stewardessComposite.Display();
        }

        public override void Add(Unit unit)
        {
            if (unit.GetType() == typeof(FirstClassPassenger)) firstClassPassengerComposite.Add(unit);
            else if (unit.GetType() == typeof(BusinessClassPassenger)) businessClassPassengerComposite.Add(unit);
            else if (unit.GetType() == typeof(EconomyClassPassenger)) economClassPassengerComposite.Add(unit);
            else if (unit.GetType() == typeof(Pilot)) pilotcomposit.Add(unit);
            else if (unit.GetType() == typeof(Stewardess)) stewardessComposite.Add(unit);
            
        }

        public override void Remove(Unit unit)
        {
            if (unit.GetType() == typeof(FirstClassPassenger)) firstClassPassengerComposite.Remove(unit);
            else if (unit.GetType() == typeof(BusinessClassPassenger)) businessClassPassengerComposite.Remove(unit);
            else if (unit.GetType() == typeof(EconomyClassPassenger)) economClassPassengerComposite.Remove(unit);
            else if (unit.GetType() == typeof(Pilot)) pilotcomposit.Remove(unit);
            else if (unit.GetType() == typeof(Stewardess)) stewardessComposite.Remove(unit);
        }

        public void Ready()
        {
            Overcrowded();
            if (Overcrowded() && (pilotcomposit.pilots.Count == 2) && (stewardessComposite.stewardesses.Count == 6)) Console.WriteLine("Ready");
            else Console.WriteLine("No ready");
        }
        private bool Overcrowded()
        {
            double count = 0;
            foreach (var i in firstClassPassengerComposite.firstClassPassengers) count += i.baggage;
            foreach (var i in businessClassPassengerComposite.businessClassPassengers) count += i.baggage;
            foreach (var i in economClassPassengerComposite.economClassPassengers) count += i.baggage;
            while(count > this.baggage)
            {
                bool check = false; 
                foreach(var i in economClassPassengerComposite.economClassPassengers)
                {
                    if (i.baggage != 0)
                    {
                        Console.WriteLine("Remove baggage passenger id: " + i.id);
                        i.baggage = 0;
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    return false;
                    
                }
            }

            return true;
            
        }

        public void mapPlane()
        {
            List<List<char>> map = new List<List<char>>();
            for(int i = 0;i < 5 ; i++)
            {
                map.Add(new List<char>());
                for(int j = 0;j < 36; j++)
                {
                    map[i].Add('0');
                }
            }

            foreach(var k in economClassPassengerComposite.economClassPassengers)
            {
                int i = k.id/30;
                int j = k.id%30 -1;
                map[i][j] = 'E';
            }

            foreach (var k in businessClassPassengerComposite.businessClassPassengers)
            {
                int i = k.id / 4;
                int j = k.id % 4 + 30;
                map[i][j] = 'B';
            }

            foreach (var k in firstClassPassengerComposite.firstClassPassengers)
            {
                int i = k.id / 2;
                int j = k.id % 2 + 34;
                map[i][j] = 'F';
            }

            foreach(var i in map)
            {
                foreach(var j in i)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
