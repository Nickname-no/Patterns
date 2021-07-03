using System;
using System.Collections.Generic;
using System.Linq;

namespace singleton
{

    interface ICar
    {
        public int id { get;  }

        public void info() { }
    }

    class Taxi : ICar
    {

        public int id { get; }

        public Taxi(int id)
        {
            this.id = id;
        }

        
        public void info()
        {
            Console.WriteLine(id);
        }



    }
    class Bus : ICar
    {

        public int id { get; }

        public Bus(int id)
        {
            this.id = id;
        }


        public void info()
        {
            Console.WriteLine(id);
        }



    }

    interface IDriver
    {
        public string name { get; }

        public  void info() { }

    }

    class BusDriver : IDriver
    {
        public string name { get;  }
        public BusDriver(string name)
        {
            this.name = name;
        }

        public  void info()
        {
            Console.WriteLine("BusDriver: " + name);
        }

    }

    class TaxiDriver : IDriver
    {
        public string name { get;  }
        public TaxiDriver(string name)
        {
            this.name = name;
        }

        public  void info()
        {
            Console.WriteLine("TaxiDriver: " + name);
        }
    }


    interface IPassenger
    {

        public int count { get; }

        public  void info() { }

       
       
    }

    class BusPassenger : IPassenger
    {
        public int count { get;  }

        public BusPassenger(int count)
        {
            if (count <= 30) this.count = count;
            else this.count = 30;
        }

        public  void info()
        {
            Console.WriteLine("BusPassenger: " + count);
        }

      
    }

    class TaxiPassenger : IPassenger
    {
        public int count { get;  }

        public TaxiPassenger(int count)
        {
            if (count <= 4) this.count = count;
            else this.count = 4;
        }

        public  void info()
        {
            Console.WriteLine("TaxiPassenger: " + count);
        }
    }

    class Transport 
    {
        public ICar car { get; set; }
        public IPassenger passenger { get; set; }
        public IDriver driver { get; set; }

        public Transport(IBoardFactory boardFactory,int idCar,int countPassenger,string name)
        {
            this.car = boardFactory.CreateCar(idCar);
            this.passenger = boardFactory.CreatePassenger(countPassenger);
            this.driver = boardFactory.CreateDriver(name);
        }

        public void info()
        {
            Console.WriteLine(car.GetType() + " Car id: " + car.id + " driver name: " + driver.name + " count passenger: " + passenger.count);
        }
    }

    interface IBoardFactory
    {
        ICar CreateCar(int id);
        IPassenger CreatePassenger(int id);
        IDriver CreateDriver(string name);
    }

    class TaxiFactory : IBoardFactory
    {
        public ICar CreateCar(int id)
        {
            return new Taxi(id);
        }
        public IPassenger CreatePassenger(int id)
        {
            return new TaxiPassenger(id);
        }
        public IDriver CreateDriver(string name)
        {
            return new TaxiDriver(name);
        }

    }

    class BusFactory : IBoardFactory
    {
        public ICar CreateCar(int id)
        {
            return new Bus(id);
        }
        public IPassenger CreatePassenger(int id)
        {
            return new BusPassenger(id);
        }
        public IDriver CreateDriver(string name)
        {
            return new BusDriver(name);
        }
    }

    class Singlton
    {
        private static Singlton single;
        public string name { get; set; }
        
        private Singlton(string name)
        {
            this.name = name;
        }

        public static Singlton getInstance(string name)
        {
            if (single == null)
                single = new Singlton(name);
            return single;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport(new TaxiFactory(), 1, 3, "Ivan");
            Transport transport2 = new Transport(new BusFactory(), 2, 31, "Ivan");
            transport.info();
            transport2.info();

            Singlton single = Singlton.getInstance("Ivan");

            Singlton single2 = Singlton.getInstance("ne Ivan");

            Console.WriteLine(single.name);
            Console.WriteLine(single2.name);

        }
    }
}
