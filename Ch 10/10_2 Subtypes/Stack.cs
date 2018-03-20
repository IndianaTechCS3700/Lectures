using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace _10_2_Subtypes
{
    class Stack
    {
        private List<string> stringList = new List<string>();

        public virtual void Push(string value)
        {
            stringList.Add(value);
        }

        public virtual string Top()
        {
            if (stringList.Count == 0)
            {
                return null;
            }

            return stringList[stringList.Count - 1];
        }

        public virtual void Pop()
        {
            stringList.RemoveAt(stringList.Count - 1);
        }
    }
}
