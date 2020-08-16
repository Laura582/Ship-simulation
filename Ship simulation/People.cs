using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ship_simulation
{
    class People
    {
        static Random rnd = new Random();

        public static string[] PeopleArray => new[]
        {
            "Tom",
            "Katherine",
            "Bill",
            "Catie",
            "Gill",
            "Kate",
            "Sun",
            "Peter",
            "Kail",
        };

        public static string[] GetRandomName(int capacity)
        {
            return PeopleArray.OrderBy(x => rnd.Next()).Take(capacity).ToArray();
        }
    }
}
