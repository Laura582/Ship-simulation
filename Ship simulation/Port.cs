using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    class Port
    {
        static Random rnd = new Random();

        public string[] _namesA;
        public string[] _namesB;
        public int _capacity;

        public Port(string[] namesA, string[] namesB, int capacity)
        {
            _namesA = namesA;
            _namesB = namesB;
            _capacity = capacity;

        }
        public string[] GetNamesPortA()
        {
            return _namesA.OrderBy(x => rnd.Next()).Take(_capacity).ToArray();
        }
        public string[] GetNamesPortB()
        {
            return _namesB.OrderBy(x => rnd.Next()).Take(_capacity).ToArray();
        }

    }
}
