using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    public class Ship
    {
        private int _maxNumberOfPeople;
        private int _currentNumberOfPeople;

        private Point _location;
        private Captain _captain;
        private Sails _sails;
        private Wheel _wheel;

        public List<Person> peopleInside = new List<Person>();
        public Ship(Captain captain, int maxNumberOfPeople, Wheel wheel, Sails sails)
        {
            _captain = captain;
            _maxNumberOfPeople = maxNumberOfPeople;
            _wheel = wheel;
            _sails = sails;
        }

        public int GetPassengersCount()
        {
            return peopleInside.Count;
        }

        public Point GetShipLocation()
        {
            return _location;
        }

        public void Move(Point location)
        {
            _captain.SetSailsUp(_sails);
            _captain.Turn(_wheel, 180);
            _location = location;
            Console.WriteLine($"Ship moves to {_location} location");
            _captain.SetSailsDown(_sails);
        }

        public void LetPeopleIn(Person[] people)
        {
            peopleInside = people.ToList();
            Console.WriteLine($"Let people in.");
            foreach (var person in people)
            {
                Console.WriteLine(person.GetName());
            }
        }

        public void LetPeopleOut()
        {
            peopleInside.Clear();
            _currentNumberOfPeople = 0;
            Console.WriteLine($"Let people out.");
        }
        public Captain GetCaptain()
        {
            return _captain;
        }
    }
}
