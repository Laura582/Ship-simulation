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

            ShipSchedule(3, 3);
        }
        public static void ShipSchedule(int times, int capacity)
        {
            Ship ship = new Ship(new Captain("Captain Spongebob"), capacity, true);
            Sails sails = new Sails();
            Wheel wheel = new Wheel();

            ship.GetCaptain().SetSailsUp(sails);
            ship.GetCaptain().Turn(wheel, 180);

            ship.Move(point1);

            for (int i = 0; i < times; i++)
            {
                ship.GetCaptain().SetSailsDown(sails);
                ship.LetPeopleOut();
                ship.LetPeopleIn(People.GetRandomPeople(capacity));

                if (ship.GetShipLocation() == point1)
                {

                    ship.GetCaptain().SetSailsUp(sails);
                    ship.GetCaptain().Turn(wheel, 180);
                    ship.Move(point2);
                }
                else
                {
                    ship.GetCaptain().SetSailsUp(sails);
                    ship.GetCaptain().Turn(wheel, 180);
                    ship.Move(point1);
                }
            }
            ship.GetCaptain().SetSailsDown(sails);
            ship.LetPeopleOut();
            ship.GetCaptain().SetSailsUp(sails);
            ship.GetCaptain().Turn(wheel, 180);
            ship.Move(point3);
            ship.GetCaptain().SetSailsDown(sails);
        }

    }
}
