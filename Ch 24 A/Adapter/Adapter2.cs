using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    internal class Provider
    {
        public int Count { get; set; }

        public void Add(int x)
        {
            // Imagine something interesting here
        }

        public int Find(int x)
        {
            // Imagine something interesting here
            return 0;
        }
    }

    interface IExCollection
    {
        public bool IsEmpty { get; set; }

        public int Size { get; set; }

        public void AddElement(int x);

        public bool ContainsElement(int x);

        public int FindElement(int x);
    }

    /// <summary>
    /// The Collection Adapter class contains and addapts the Provider class to the IExCollection interface.
    /// </summary>
    internal class CollectionAdapter : IExCollection
    {
        private Provider data = new Provider();

        #region IExCollection Members

        public bool IsEmpty
        {
            get
            {
                return (data.Count == 0);
            }
        }

        public int Size
        {
            get
            {
                return data.Count;
            }
        }

        public void AddElement(int x)
        {
            data.Add(x);
        }

        public bool ContainsElement(int x)
        {
            if (data.Find(x) == null)
                return false;

            return true;
        }

        public int FindElement(int x)
        {
            return data.Find(x);
        }

        #endregion IExCollection Members
    }

    // The adapter doesn't do much work but it does
    // provide old functionality packaged in new ways.
}