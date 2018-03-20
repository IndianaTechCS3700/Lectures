using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamespaceVisibility
{

    class Law
    {
        public string Name { get; set; }
    }

    class Demeter
    {
        public Law MyLaw { get; set; }
    }

    class  Principle
    {
        public Demeter MyDemeter { get; set; }

        public void SetName(string name)
        {

        }
    }

    class MyProgram
    {
        public void Main()
        {
            var principle = new Principle();
            //principle.MyDemeter = new Demeter();
            //principle.MyDemeter.MyLaw = new Law();
            principle.MyDemeter.MyLaw.Name = "some name";

            principle.SetName("some name");
        }
    }
}
