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

        public void Move(Point location)
        {
            
            if (_wheel == true)
            {
                
                    _location = location;
                    Console.WriteLine($"Ship moves to {_location} location");
                
               
            }
            else
            {
                Console.WriteLine("In order to move you need wheel");
            }
        }

        public void LetPeopleIn(string[] ArrayOfPeople, int capacity)
        {
            Person person = new Person(ArrayOfPeople);
            GetCurrentNumberOfPeople(person.GetName());
            
        }

        public void LetPeopleOut()
        {
            peopleInside.Clear();
            _currentNumberOfPeople = 0;
            Console.WriteLine($"Let people out.");
        }
    }
}
