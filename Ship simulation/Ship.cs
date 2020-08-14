using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    public class Ship
    {
        public bool _locationA;
        public bool _locationB;
        public bool _locationC;

        public int _maxNumberOfPeople;
        public int _currentNumberOfPeople;

        public bool _captain;
        private bool _fuel;

        public List<string> peopleInside = new List<string>();

        public Ship(int maxNumberOfPeople, bool captain, bool fuel)
        {
            _captain = captain;
            _maxNumberOfPeople = maxNumberOfPeople;
            _fuel = fuel;
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

        public bool GetLocationA()
        {
            Console.WriteLine("Ship is in A location");
            return _locationA;
        }
        public bool GetLocationB()
        {
            Console.WriteLine("Ship is in B location");
            return _locationB;
        }
        public bool GetLocationC()
        {
            Console.WriteLine("Ship is in dock");
            return _locationC;
        }
        public bool GetShipLocation()
        {
            if (_locationA == true)
            {
                return GetLocationA();
            }
            else if (_locationB == true)
            {
                return GetLocationB();
            }
            else
            {
                return GetLocationC();

            }
        }

        public void Move(bool locationA, bool locationB)
        {
            if (_captain == true && _fuel == true)
            {
                _locationA = locationA;
                _locationB = locationB;
            }
            else
            {
                Console.WriteLine("In order to move you need captain and fuel");
                
            }
            
        }


        public void LetPeopleIn()
        {
            if (_locationA == true)
            {
                GetCurrentNumberOfPeople(People.PeoplWhoAreWaitingInADestination);
            }
            if (_locationB == true)
            {
                GetCurrentNumberOfPeople(People.PeoplWhoAreWaitingInBDestination);
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
