using System;

namespace Builder
{
    
    public interface IPassenger
    {
        public int price { get; }
        public void  info();
    }

    class Beneficiary : IPassenger
    {
        public int price { get; }

        public Beneficiary()
        {
            this.price = 20;
        }


        public void info()
        {
            Console.WriteLine(price);
        }
    }
    
    class Adult : IPassenger
    {
        
        public int price { get; }

        public Adult()
        {
            this.price = 50;
        }


        public void info()
        {
            Console.WriteLine(price);
        }
    }
    
    class Child : IPassenger
    {
        public int price { get; }

        public Child()
        {
            this.price = 20;
        }


        public void info()
        {
            Console.WriteLine(price);
        }
    }
}