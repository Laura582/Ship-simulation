using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Ship_simulation
{
    class Program
    { 

        static public Point point1 = new Point(10, 10);
        static public Point point2 = new Point(20, 20);
        static public Point point3 = new Point(30, 30);


        static void Main(string[] args)
        {

            ShipSchedule(3, 2);
        }
        public static void ShipSchedule(int times, int capacity)
        {
            Ship ship = new Ship("Captain", capacity, true);
            ship.Move(point1, People.PeopleWhoAreWaitingInDockDestination);

            for (int i = 0; i < times; i++)
            {
                ship.LetPeopleOut();
                ship.LetPeopleIn(People.PeopleWhoAreWaitingInADestination, People.PeopleWhoAreWaitingInBDestination, capacity);

                if (ship.GetShipLocation() == point1)
                {
                    ship.Move(point2, People.PeopleWhoAreWaitingInDockDestination);
                }
                else
                {
                    ship.Move(point1, People.PeopleWhoAreWaitingInDockDestination);
                }
            }

            ship.LetPeopleOut();
            ship.Move(point3, People.PeopleWhoAreWaitingInDockDestination);
        }

    }
}
