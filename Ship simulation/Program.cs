using System;

namespace Ship_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(2, true, true);
            ship.GetShipLocation();
            ship.Move(true, false);
            ship.GetShipLocation();
            ship.LetPeopleIn();
            ship.Move(false, true);
            ship.GetShipLocation();
            ship.LetPeopleOut();
            ship.LetPeopleIn();
            ship.Move(true, false);
            ship.GetShipLocation();
            ship.LetPeopleOut();
            ship.Move(false, false);
            ship.GetShipLocation();

        }
    }
}
