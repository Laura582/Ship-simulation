using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_simulation
{
    class Dock
    {
        string[] _namesDock;
        public Dock(string[] namesDock)
        {
            _namesDock = namesDock;
        }
        public string GetCaptainName()
        {
            string stringToCheck = "Captain";
            string error = "There is no captain";

            foreach (string Captain in _namesDock)
            {
                if (stringToCheck.Contains(Captain))
                {
                    return Captain;
                }
            }
            return error;

        }
    }
}
