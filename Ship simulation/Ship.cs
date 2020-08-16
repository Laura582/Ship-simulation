using System;
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

        public List<string> peopleInside = new List<string>();

        public Ship(string captain, int maxNumberOfPeople)
        {
            _captain = captain;
            _maxNumberOfPeople = maxNumberOfPeople;
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

        public void Move(Point location)
        {

            if (_captain == "captain")
            {
                _location = location;
                Console.WriteLine($"Ship moves to {_location} location");
            }
            else
            {
                Console.WriteLine("In order to move you need captain");
            }
        }

        public void LetPeopleIn(string[] ArrayOfPeopleA, string[] ArrayOfPeopleB)
        {
            if (_location == Program.point1)
            {
                GetCurrentNumberOfPeople(ArrayOfPeopleA);
            }
            if (_location == Program.point2)
            {
                GetCurrentNumberOfPeople(ArrayOfPeopleB);
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
