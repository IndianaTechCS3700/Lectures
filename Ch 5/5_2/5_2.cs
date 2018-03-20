using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//A distinction we will see throughout the term is between the following:

/// A statically typed language requires the programmer to declare a type
/// for each variable.  The validity of a message passing expression will
/// be checked at compile time, based on the declared type of the receiver.

/// A dynamically typed language associates types with values, not with
/// variables.  A variable is just a name. The legality of a message
/// cannot be determined until run-time.

namespace _5_2
{
    class Coords
    {
        public int x;
        public int y;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var coords = new Coords();
            coords.x = 7;
            coords.y = 8;
            coords.z = 9;
        }
    }
}