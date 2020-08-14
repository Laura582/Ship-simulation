using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    public class Ship
    {
        public bool _locationA = false;
        public bool _locationB = false;

        public int _maxNumberOfPeople;
        public int _currentNumberOfPeople;

        public List<string> peopleInside = new List<string>();

        public Ship(int maxNumberOfPeople)
        {
            _maxNumberOfPeople = maxNumberOfPeople;
        }

        public List<string> GetCurrentNumberOfPeople(string[] PeopleArray)
        {


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
            Console.WriteLine(_locationA);
            return _locationA;
        }
        public bool GetLocationB()
        {
            Console.WriteLine(_locationB);
            return _locationB;
        }

        public void Move(bool locationA, bool locationB)
        {
            _locationA = locationA;
            _locationB = locationB;
            Console.WriteLine($"Ship location A: {locationA} and location B: {locationB}");
        }

        public void LocationA()
        {
            if (_locationA == true)
            {
                GetCurrentNumberOfPeople(People.PeoplWhoAreWaitingInADestination);
                Console.WriteLine($"let people in (A){_currentNumberOfPeople}");
            }
        }


        public void LocationB()
        {
            if (_locationB == true)
            {
                GetCurrentNumberOfPeople(People.PeoplWhoAreWaitingInBDestination);
                Console.WriteLine($"let people in (B){_currentNumberOfPeople}");
            }

        }
        public void LetPeopleOut()
        {
            peopleInside.Clear();
            Console.WriteLine($"People out{peopleInside.Count}");
        }
    }
}
