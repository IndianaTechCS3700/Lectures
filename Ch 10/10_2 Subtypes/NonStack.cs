using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_2_Subtypes
{
    class NonStack : Stack
    {
        string storageString;

        public override void Pop()
        {
            storageString = null;
        }

        public override string Top()
        {
            return storageString;
        }

        public override void Push(string value)
        {
            storageString = value;
        }
    }
}
