using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    class Port
    {
        static Random rnd = new Random();

        public string[] _names;

        public Port (string[] names)
        {
            _names = names;

        }
        public static string[] GetNames(string[] ArrayPeople, int capacity)
         => ArrayPeople.OrderBy(x => rnd.Next()).Take(capacity).ToArray();
    }
}
