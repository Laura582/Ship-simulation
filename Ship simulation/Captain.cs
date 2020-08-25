using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_simulation
{
    public class Captain : Person
    {
        public Captain(string name) : base (name)
        {

        }
        public void SetSailsUp(Sails sails)
        {
            Console.WriteLine("Set Sails up");
        }
        public void SetSailsDown(Sails sails)
        {
            Console.WriteLine("Set Sails down");
        }

        public void Turn(Wheel wheel, int degrees)
        {
            Console.WriteLine($"Turn wheel {degrees} degrees");
        }
    }
}
