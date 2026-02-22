using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP
{
    public struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Row}-{Number}";
        }
    }
}
