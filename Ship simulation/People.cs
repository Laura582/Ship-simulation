using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ship_simulation
{
    public class People
    {
        static Random rnd = new Random();

        public static string[] names => new[]
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

        public static Person[] GetRandomPeople(int capacity)
        {
            var pplNames = names
                .OrderBy(x => rnd.Next())
                .Take(capacity);

            List<Person> people = new List<Person>();

            foreach (var personName in pplNames)
            {
                people.Add(new Person(personName));
            }
            return people.ToArray();


        }
    }
}
