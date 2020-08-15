using System;

namespace Ship_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipSchedule(3);
        }
        public static void ShipSchedule(int times)
        {
            Ship ship = new Ship("captain", 2);
            ship.Move("PointA");

            for (int i = 0; i < times; i++)
            {
                ship.LetPeopleOut();
                ship.LetPeopleIn(People.PeopleWhoAreWaitingInADestination, People.PeopleWhoAreWaitingInBDestination);

                if (ship.GetShipLocation() == "PointA")
                {
                    ship.Move("PointB");
                }
                else
                {
                    ship.Move("PointA");
                }
            }

            ship.LetPeopleOut();
            ship.Move("dock");
        }
    }
}
