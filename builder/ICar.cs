using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICar
    {
        public void info() { }
    }

    public class Bus : ICar
    {
        public void info()
        {
            Console.WriteLine("Bus");
        }
    }

    public class Taxi : ICar
    {
        
        public void info()
        {
            Console.WriteLine("Taxi");
        }
    }

    public class Ship : ICar
    {
        public void  info()
        {
            Console.WriteLine("Ship");
        }

    }
}
