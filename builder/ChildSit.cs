using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ChildSit
    {

        public int countChildSit { get; set; }
        public abstract void info();
    }

    public class ShipChildSit : ChildSit
    {
        
        public override void info()
        {
            Console.WriteLine("count life vest: " + countChildSit);
        }
    }

    public class TaxiChildsit : ChildSit
    {
        public override void info()
        {
            Console.WriteLine("Count child sit: " + countChildSit);
        }
    }
}
