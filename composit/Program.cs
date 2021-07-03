using System;

namespace Composit
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(1, 1000);
            plane.Add(new Pilot(1));
            plane.Add(new Pilot(2));
            plane.Add(new Stewardess(1));
            plane.Add(new Stewardess(2));
            plane.Add(new Stewardess(3));
            plane.Add(new Stewardess(4));
            plane.Add(new Stewardess(5));
            plane.Add(new Stewardess(6));
            plane.Add(new FirstClassPassenger(1, 50));
            plane.Add(new FirstClassPassenger(2, 50));
            plane.Add(new EconomyClassPassenger(1, 10));
            plane.Add(new EconomyClassPassenger(2, 10));
            plane.Add(new EconomyClassPassenger(3, 10));
            plane.Add(new BusinessClassPassenger(1, 20));
            plane.Add(new BusinessClassPassenger(2, 20));
            plane.Add(new BusinessClassPassenger(3, 20));
            plane.Ready();
            plane.mapPlane();
            Console.WriteLine();
            plane.Remove(plane.firstClassPassengerComposite.firstClassPassengers[0]);
            plane.mapPlane();
            
            
        }
    }
}
