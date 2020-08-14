using System;

namespace Ship_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(2);
            ship.Move(true, false);
            ship.LocationA();
            ship.Move(false, true);
            ship.LetPeopleOut();
            ship.LocationB();
            
          
        }
    }
}
