﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    public class Ship
    {
        public int _maxNumberOfPeople;
        public int _currentNumberOfPeople;

        public Point _location;
        public string _captain;
        public bool _wheel;

        public List<string> peopleInside = new List<string>();

        public Ship(string captain, int maxNumberOfPeople, bool wheel)
        {
            _captain = captain;
            _maxNumberOfPeople = maxNumberOfPeople;
            _wheel = wheel;
        }

        public List<string> GetCurrentNumberOfPeople(string[] PeopleArray)
        {
            Console.WriteLine("Let people in: ");

            for (int i = 0; i < PeopleArray.Length; i++)
            {
                if (peopleInside.Count < _maxNumberOfPeople)
                {
                    peopleInside.Add(PeopleArray[i]);
                    Console.WriteLine(peopleInside[i]);
                }
            }
            _currentNumberOfPeople = peopleInside.Count;

            return peopleInside;
        }

        public Point GetShipLocation()
        {
            return _location;
        }

        public void Move(Point location, string[] ArrayOfPeopleDock)
        {
            Dock dock = new Dock(ArrayOfPeopleDock);
            var captainName = dock.GetCaptainName();
            if (_wheel == true)
            {
                if (captainName.Contains(_captain))
                {
                    _location = location;
                    Console.WriteLine($"Ship moves to {_location} location");
                }
                else
                {
                    Console.WriteLine("In order to move you need captain");
                }
            }
            else
            {
                Console.WriteLine("In order to move you need wheel");
            }
        }

        public void LetPeopleIn(string[] ArrayOfPeopleA, string[] ArrayOfPeopleB, int capacity)
        {
            Port port = new Port(ArrayOfPeopleA, ArrayOfPeopleB, capacity);

            if (_location == Program.point1)
            {
                GetCurrentNumberOfPeople(port.GetNamesPortA());
            }
            if (_location == Program.point2)
            {
                GetCurrentNumberOfPeople(port.GetNamesPortB());
            }
        }

        public void LetPeopleOut()
        {
            peopleInside.Clear();
            _currentNumberOfPeople = 0;
            Console.WriteLine($"Let people out.");
        }
    }
}
