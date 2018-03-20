using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace _10_4_Subclassing_for_limitation
{
    class Stack : List<String>
    {
        public void Push(string value)
        {
            this.Add(value);
        }

        public virtual string Top()
        {
            if (this.Count == 0)
            {
                return null;
            }

            return this[this.Count - 1];
        }

        public virtual void Pop()
        {
            this.RemoveAt(this.Count - 1);

            
        }

        public new void Insert(int index, string value)
        {
            
        }

        public new void RemoveAt(int index)
        {

        }

        
    }
}

/// What does it mean to say that one class is a subclass of another?
/// What is the principle of substitution?
/// Which properties of a type are not captured in an interface defintion?
